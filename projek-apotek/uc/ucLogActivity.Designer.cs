namespace projek_apotek.uc
{
    partial class ucLogActivity
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
            this.gdKelolaObat = new System.Windows.Forms.DataGridView();
            this.dtEXP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdKelolaObat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Log user";
            // 
            // gdKelolaObat
            // 
            this.gdKelolaObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdKelolaObat.Location = new System.Drawing.Point(20, 55);
            this.gdKelolaObat.Name = "gdKelolaObat";
            this.gdKelolaObat.Size = new System.Drawing.Size(494, 333);
            this.gdKelolaObat.TabIndex = 30;
            // 
            // dtEXP
            // 
            this.dtEXP.CalendarFont = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEXP.Location = new System.Drawing.Point(108, 406);
            this.dtEXP.Name = "dtEXP";
            this.dtEXP.Size = new System.Drawing.Size(269, 20);
            this.dtEXP.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(16, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tanggal";
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(417, 406);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(97, 24);
            this.btnGetData.TabIndex = 33;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.button1_Click);
            // 
            // ucLogActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEXP);
            this.Controls.Add(this.gdKelolaObat);
            this.Controls.Add(this.label1);
            this.Name = "ucLogActivity";
            this.Size = new System.Drawing.Size(534, 436);
            this.Load += new System.EventHandler(this.ucLogActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdKelolaObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gdKelolaObat;
        private System.Windows.Forms.DateTimePicker dtEXP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetData;
    }
}
