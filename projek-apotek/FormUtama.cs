using projek_apotek.uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projek_apotek
{
    public partial class formUtama : Form
    {
        ucKelolaObat menuObat = new ucKelolaObat();
        ucKelolaResep menuResep = new ucKelolaResep();
        ucKelolaUser menuUser = new ucKelolaUser();
        ucLaporan menuLaporan = new ucLaporan();
        ucLogActivity menuLog = new ucLogActivity();
        ucTransaksi menuTransaksi = new ucTransaksi();
        ucPengaturan menuPengaturan = new ucPengaturan();

        public formUtama(string tipe)
        {
            menuObat.Dock = DockStyle.Fill;
            menuResep.Dock = DockStyle.Fill;
            menuUser.Dock = DockStyle.Fill;
            menuLaporan.Dock = DockStyle.Fill;
            menuLog.Dock = DockStyle.Fill;
            menuTransaksi.Dock = DockStyle.Fill;

            InitializeComponent();
            labelWelcome.Text = "Selamat Datang, " + LoginSession.nama;
            labelNamaAplikasi.Text = Properties.Settings.Default.namaAplikasi;
            multiAuth(tipe);
        }

        public formUtama()
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }
        private void multiAuth(string tipe)
        {
            if (tipe != "Admin")
                flowLayoutPanel1.Visible = false;
            else
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuLog);
            }

            if (tipe == "Apoteker")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuResep);
            }
            else if (tipe == "Kasir")
            {
                panelControl.Controls.Clear();
                panelControl.Controls.Add(menuTransaksi);
            }
        }

        private void btnObat_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuObat);
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLaporan);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuLog);
        }

        private void btnPengaturan_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuPengaturan);
        }

        private void btnMenuUser_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuUser);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formUtama_Load(object sender, EventArgs e)
        {

        }

        private void labelNamaAplikasi_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelControl.Controls.Clear();
            panelControl.Controls.Add(menuResep);
        }
    }
}
