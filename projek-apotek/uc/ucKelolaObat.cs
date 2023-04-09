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
    public partial class ucKelolaObat : UserControl
    {
        Obat obat = new Obat();

        private void clear()
        {
            txtNamaObat.Clear();
            txtKodeObat.Clear();
            dtEXP.Value = DateTime.Now;
            txtJmlhObat.Clear();
            txtHargaPerUnit.Clear();
        }
        public ucKelolaObat()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (obat.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan di edit!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJmlhObat.Text) || String.IsNullOrEmpty(txtHargaPerUnit.Text))
                {
                    MessageBox.Show("Lengkapi semua data!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                obat.nama_obat = txtNamaObat.Text;
                obat.kode_obat = txtKodeObat.Text;
                obat.expired_date = dtEXP.Value;
                obat.jumlah = Convert.ToInt64(txtJmlhObat.Text);
                obat.harga = Convert.ToInt64(txtHargaPerUnit.Text);
                int n = obat.editData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    obat.getData(null, gdKelolaObat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formMenuObat_Load(object sender, EventArgs e)
        {
            clear();
            obat.getData(null, gdKelolaObat);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtKodeObat.Text) || String.IsNullOrEmpty(txtNamaObat.Text) || String.IsNullOrEmpty(txtJmlhObat.Text) || String.IsNullOrEmpty(txtHargaPerUnit.Text))
                {
                    MessageBox.Show("Legkapi Semua Data!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                    obat.nama_obat = txtNamaObat.Text;
                    obat.kode_obat = txtKodeObat.Text;
                    obat.expired_date = dtEXP.Value;
                    obat.jumlah = Convert.ToInt32(txtJmlhObat.Text);
                    obat.harga = Convert.ToInt32(txtHargaPerUnit.Text);
                int n = obat.AddData(obat);
                if (n == 0)
                    MessageBox.Show("Data gagal disimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    obat.getData(null, gdKelolaObat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try { 
            if (obat.id == 0)
            {
                MessageBox.Show("Mohon pilih obat yang akan dihapus!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int n = obat.deleteData(obat);
            if (n == 0)
                MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Data berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obat.id = 0;
                clear();
                obat.getData(null, gdKelolaObat);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            obat.getData(txtCari.Text, gdKelolaObat);
        }

        private void gdKelolaObat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                obat.id = Convert.ToInt32(gdKelolaObat.Rows[row_index].Cells[0].Value.ToString()); 
                obat.kode_obat = gdKelolaObat.Rows[row_index].Cells[1].Value.ToString();
                obat.nama_obat = gdKelolaObat.Rows[row_index].Cells[2].Value.ToString();
                obat.expired_date = Convert.ToDateTime(gdKelolaObat.Rows[row_index].Cells[3].Value.ToString());
                obat.jumlah = Convert.ToInt64(gdKelolaObat.Rows[row_index].Cells[4].Value.ToString());
                obat.harga = Convert.ToInt64(gdKelolaObat.Rows[row_index].Cells[5].Value.ToString());
                txtKodeObat.Text = obat.kode_obat;
                txtNamaObat.Text = obat.nama_obat;
                dtEXP.Value = obat.expired_date;
                txtJmlhObat.Text = obat.jumlah.ToString();
                txtHargaPerUnit.Text = obat.harga.ToString();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void validasi_AngkaTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void txtHargaPerUnit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
