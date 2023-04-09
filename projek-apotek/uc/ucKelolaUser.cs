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
    public partial class ucKelolaUser : UserControl
    {
        User user = new User();

        private void clear()
        {
            cbTipeUser.SelectedIndex = -1;
            txtNamaUser.Clear();
            txtPassword.Clear();
            txtTelepon.Clear();
            txtUsername.Clear();
            txtAlamat.Clear();
        }
        public ucKelolaUser()
        {
            InitializeComponent();
        }

        private void ucKelolaUser_Load(object sender, EventArgs e)
        {
            clear();
            user.getData(null, gdKelolaUser);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan di edit!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (String.IsNullOrEmpty(txtNamaUser.Text) || String.IsNullOrEmpty(txtPassword.Text) || cbTipeUser.SelectedIndex == -1 || String.IsNullOrEmpty(txtTelepon.Text) || String.IsNullOrEmpty(txtUsername.Text)|| String.IsNullOrEmpty(txtAlamat.Text))
                {
                    MessageBox.Show("Lengkapi semua data!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                user.nama = txtNamaUser.Text;
                user.password = txtPassword.Text;
                user.username = txtUsername.Text;
                user.telepon = txtTelepon.Text;
                user.alamat = txtAlamat.Text;
                user.tipe_user = cbTipeUser.SelectedItem.ToString();
               
                int n = user.editData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal diedit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil diedit!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    user.getData(null, gdKelolaUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                if (user.id == 0)
                {
                    MessageBox.Show("Mohon pilih data yang akan dihapus!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int n = user.deleteData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil dihapus!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    user.id = 0;
                    clear();
                       user.getData(null, gdKelolaUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNamaUser.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtUsername.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtAlamat.Text) || String.IsNullOrEmpty(txtTelepon.Text))
                {
                    MessageBox.Show("Lengkapi Semua Data!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                user.nama = txtNamaUser.Text;
                user.username = txtUsername.Text;
                user.telepon = txtTelepon.Text;
                user.password = txtPassword.Text;
                user.alamat = txtAlamat.Text;
                user.tipe_user= cbTipeUser.SelectedItem.ToString();
                
                int n = user.AddData(user);
                if (n == 0)
                    MessageBox.Show("Data gagal disimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Data berhasil disimpan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    user.getData(null, gdKelolaUser);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            user.getData(txtCari.Text, gdKelolaUser);
        }

        private void gdKelolaUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;
                user.id = Convert.ToInt32(gdKelolaUser.Rows[row_index].Cells[0].Value.ToString());
                user.nama = gdKelolaUser.Rows[row_index].Cells[1].Value.ToString();
                user.password = gdKelolaUser.Rows[row_index].Cells[2].Value.ToString();
                user.telepon = gdKelolaUser.Rows[row_index].Cells[3].Value.ToString();
                user.alamat = gdKelolaUser.Rows[row_index].Cells[4].Value.ToString();
                user.tipe_user = gdKelolaUser.Rows[row_index].Cells[5].Value.ToString();
                user.username = gdKelolaUser.Rows[row_index].Cells[6].Value.ToString();
                int i = cbTipeUser.Items.IndexOf(user.tipe_user);
                txtNamaUser.Text = user.nama;
                txtPassword.Text = user.password;
                txtUsername.Text = user.username;
                txtTelepon.Text = user.telepon;
                txtAlamat.Text = user.alamat;
                cbTipeUser.SelectedIndex = i;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
