﻿namespace projek_apotek
{
    partial class formUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelNamaAplikasi = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPengaturan = new System.Windows.Forms.Button();
            this.btnMenuUser = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.picApp = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(538, 18);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(201, 26);
            this.labelWelcome.TabIndex = 14;
            this.labelWelcome.Text = "Selamat Datang. [Nama User]";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(533, 47);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(207, 26);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Senin, 02 Januari 2022 33:33:33";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNamaAplikasi
            // 
            this.labelNamaAplikasi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaAplikasi.Location = new System.Drawing.Point(205, 9);
            this.labelNamaAplikasi.Name = "labelNamaAplikasi";
            this.labelNamaAplikasi.Size = new System.Drawing.Size(245, 40);
            this.labelNamaAplikasi.TabIndex = 12;
            this.labelNamaAplikasi.Text = "Apotek Sejahtera";
            this.labelNamaAplikasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNamaAplikasi.Click += new System.EventHandler(this.labelNamaAplikasi_Click);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.ForestGreen;
            this.panelControl.Location = new System.Drawing.Point(214, 75);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(534, 436);
            this.panelControl.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.picApp);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 526);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnPengaturan);
            this.flowLayoutPanel1.Controls.Add(this.btnMenuUser);
            this.flowLayoutPanel1.Controls.Add(this.btnObat);
            this.flowLayoutPanel1.Controls.Add(this.btnLaporan);
            this.flowLayoutPanel1.Controls.Add(this.btnLog);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(159, 211);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // btnPengaturan
            // 
            this.btnPengaturan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPengaturan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnPengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPengaturan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPengaturan.ForeColor = System.Drawing.Color.White;
            this.btnPengaturan.Location = new System.Drawing.Point(0, 3);
            this.btnPengaturan.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnPengaturan.Name = "btnPengaturan";
            this.btnPengaturan.Size = new System.Drawing.Size(157, 37);
            this.btnPengaturan.TabIndex = 5;
            this.btnPengaturan.Text = "PENGATURAN APLIKASI";
            this.btnPengaturan.UseVisualStyleBackColor = false;
            this.btnPengaturan.Click += new System.EventHandler(this.btnPengaturan_Click);
            // 
            // btnMenuUser
            // 
            this.btnMenuUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenuUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnMenuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUser.ForeColor = System.Drawing.Color.White;
            this.btnMenuUser.Location = new System.Drawing.Point(0, 45);
            this.btnMenuUser.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnMenuUser.Name = "btnMenuUser";
            this.btnMenuUser.Size = new System.Drawing.Size(157, 37);
            this.btnMenuUser.TabIndex = 6;
            this.btnMenuUser.Text = "KELOLA USER";
            this.btnMenuUser.UseVisualStyleBackColor = false;
            this.btnMenuUser.Click += new System.EventHandler(this.btnMenuUser_Click);
            // 
            // btnObat
            // 
            this.btnObat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnObat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObat.ForeColor = System.Drawing.Color.White;
            this.btnObat.Location = new System.Drawing.Point(0, 87);
            this.btnObat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(157, 37);
            this.btnObat.TabIndex = 1;
            this.btnObat.Text = "KELOLA OBAT";
            this.btnObat.UseVisualStyleBackColor = false;
            this.btnObat.Click += new System.EventHandler(this.btnObat_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Location = new System.Drawing.Point(0, 129);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(157, 37);
            this.btnLaporan.TabIndex = 2;
            this.btnLaporan.Text = "KELOLA LAPORAN";
            this.btnLaporan.UseVisualStyleBackColor = false;
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnLog
            // 
            this.btnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLog.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.Location = new System.Drawing.Point(0, 171);
            this.btnLog.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(157, 37);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "LOG USER";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // picApp
            // 
            this.picApp.Location = new System.Drawing.Point(14, 12);
            this.picApp.Name = "picApp";
            this.picApp.Size = new System.Drawing.Size(155, 146);
            this.picApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picApp.TabIndex = 4;
            this.picApp.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(14, 477);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(157, 37);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(130)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "menu resep";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 526);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelNamaAplikasi);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panel1);
            this.Name = "formUtama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Utama";
            this.Load += new System.EventHandler(this.formUtama_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelNamaAplikasi;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnMenuUser;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnPengaturan;
        private System.Windows.Forms.PictureBox picApp;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Button button1;
    }
}

