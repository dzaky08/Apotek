using projek_apotek.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek.uc
{
    public partial class ucResep : UserControl
    {

        Resep resep = new Resep();

        private void clear()
        {
            txtNoResep.Clear();
            txtNamaDokter.Clear();
            txtNamaPasien.Clear();
            txtQty.Clear();
            txtObatResep.Clear();
            dtTglResep.Value = DateTime.Now;
            txtCari.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            resep.getData(txtCari.Text, gdKelolaResep);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucResep_Load(object sender, EventArgs e)
        {
            clear();
            resep.getData(null, gdKelolaResep);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (resep.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan dihapus!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = resep.deleteData(resep);
                if (n == 0)
                    MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    resep.id = 0;
                    clear();
                    resep.getData(null, gdKelolaResep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (resep.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan di edit!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtNoResep.Text) || String.IsNullOrEmpty(txtObatResep.Text) || String.IsNullOrEmpty(txtQty.Text) || String.IsNullOrEmpty(txtNamaDokter.Text) || String.IsNullOrEmpty(txtNamaPasien.Text))
                {
                    MessageBox.Show("Lengkapi semua data!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                resep.obat_resep = txtObatResep.Text;
                resep.nama_dokter = txtNamaDokter.Text;
                resep.tgl_resep = dtTglResep.Value;
                resep.nama_pasien = txtNamaPasien.Text;
                resep.no_resep = txtNoResep.Text;
                resep.stok = Convert.ToInt32(txtQty.Text);
                int n = resep.editData(resep);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    resep.getData(null, gdKelolaResep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gdKelolaResep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                resep.id = Convert.ToInt32(gdKelolaResep.Rows[index].Cells[0].Value.ToString());
                resep.no_resep = gdKelolaResep.Rows[index].Cells[1].Value.ToString();
                resep.nama_dokter = gdKelolaResep.Rows[index].Cells[2].Value.ToString();
                resep.nama_pasien = gdKelolaResep.Rows[index].Cells[3].Value.ToString();
                resep.obat_resep = gdKelolaResep.Rows[index].Cells[4].Value.ToString();
                resep.tgl_resep = Convert.ToDateTime(gdKelolaResep.Rows[index].Cells[5].Value.ToString());
                resep.stok = Convert.ToInt32(gdKelolaResep.Rows[index].Cells[6].Value.ToString());

                txtNoResep.Text = resep.no_resep;
                txtNamaDokter.Text = resep.nama_dokter;
                txtNamaPasien.Text = resep.nama_pasien;
                txtObatResep.Text = resep.obat_resep;
                dtTglResep.Value = resep.tgl_resep;
                txtQty.Text = resep.stok.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void txtNoResep_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
