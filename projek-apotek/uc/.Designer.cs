namespace projek_apotek.uc
{
    partial class ucKelolaObat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKodeObat = new System.Windows.Forms.TextBox();
            this.txtJmlhObat = new System.Windows.Forms.TextBox();
            this.txtHargaPerUnit = new System.Windows.Forms.TextBox();
            this.txtNamaObat = new System.Windows.Forms.TextBox();
            this.dtEXP = new System.Windows.Forms.DateTimePicker();
            this.gdKelolaObat = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdKelolaObat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(293, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jumlah Obat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nama Obat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(293, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harga Per unit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(13, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Expired Date";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtKodeObat
            // 
            this.txtKodeObat.Location = new System.Drawing.Point(17, 93);
            this.txtKodeObat.Name = "txtKodeObat";
            this.txtKodeObat.Size = new System.Drawing.Size(216, 20);
            this.txtKodeObat.TabIndex = 6;
            // 
            // txtJmlhObat
            // 
            this.txtJmlhObat.Location = new System.Drawing.Point(297, 94);
            this.txtJmlhObat.Name = "txtJmlhObat";
            this.txtJmlhObat.Size = new System.Drawing.Size(216, 20);
            this.txtJmlhObat.TabIndex = 7;
            this.txtJmlhObat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtJmlhObat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validasi_AngkaTextBox);
            // 
            // txtHargaPerUnit
            // 
            this.txtHargaPerUnit.Location = new System.Drawing.Point(297, 149);
            this.txtHargaPerUnit.Name = "txtHargaPerUnit";
            this.txtHargaPerUnit.Size = new System.Drawing.Size(216, 20);
            this.txtHargaPerUnit.TabIndex = 8;
            this.txtHargaPerUnit.TextChanged += new System.EventHandler(this.txtHargaPerUnit_TextChanged);
            this.txtHargaPerUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validasi_AngkaTextBox);
            // 
            // txtNamaObat
            // 
            this.txtNamaObat.Location = new System.Drawing.Point(16, 149);
            this.txtNamaObat.Name = "txtNamaObat";
            this.txtNamaObat.Size = new System.Drawing.Size(216, 20);
            this.txtNamaObat.TabIndex = 9;
            // 
            // dtEXP
            // 
            this.dtEXP.CalendarFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEXP.Location = new System.Drawing.Point(17, 210);
            this.dtEXP.Name = "dtEXP";
            this.dtEXP.Size = new System.Drawing.Size(216, 20);
            this.dtEXP.TabIndex = 10;
            // 
            // gdKelolaObat
            // 
            this.gdKelolaObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdKelolaObat.Location = new System.Drawing.Point(8, 284);
            this.gdKelolaObat.Name = "gdKelolaObat";
            this.gdKelolaObat.Size = new System.Drawing.Size(519, 143);
            this.gdKelolaObat.TabIndex = 12;
            this.gdKelolaObat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdKelolaObat_CellContentClick);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(20, 251);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(88, 26);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(207, 251);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(88, 26);
            this.btnHapus.TabIndex = 14;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(115, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 26);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(300, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Cari :";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(358, 254);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(155, 20);
            this.txtCari.TabIndex = 17;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // ucKelolaObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gdKelolaObat);
            this.Controls.Add(this.dtEXP);
            this.Controls.Add(this.txtNamaObat);
            this.Controls.Add(this.txtHargaPerUnit);
            this.Controls.Add(this.txtJmlhObat);
            this.Controls.Add(this.txtKodeObat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucKelolaObat";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.formMenuObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdKelolaObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKodeObat;
        private System.Windows.Forms.TextBox txtJmlhObat;
        private System.Windows.Forms.TextBox txtHargaPerUnit;
        private System.Windows.Forms.TextBox txtNamaObat;
        private System.Windows.Forms.DateTimePicker dtEXP;
        private System.Windows.Forms.DataGridView gdKelolaObat;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCari;
    }
}
