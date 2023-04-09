using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projek_apotek.models;

namespace projek_apotek
{
    public partial class Login : Form
    {
       User user = new User();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            user.username = txtUsername.Text;
            user.password = txtPassword.Text;

            var status = user.login(user);
            if(status == true)
            {
                this.Hide();
                txtUsername.Clear();
                txtPassword.Clear();
                new formUtama(LoginSession.tipe).ShowDialog();
                this.Show();

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
