﻿
namespace tugasbesar
{
    partial class frmLaporan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.transaksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsemua = new System.Windows.Forms.Button();
            this.btnhapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(-3, -2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(638, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "LAPORAN";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transaksi
            // 
            this.transaksi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.transaksi.BackColor = System.Drawing.SystemColors.Info;
            this.transaksi.Location = new System.Drawing.Point(173, 90);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(217, 29);
            this.transaksi.TabIndex = 17;
            this.transaksi.TextChanged += new System.EventHandler(this.transaksi_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "ID Transaksi";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSubmit.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(435, 90);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(58, 31);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Lihat";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(314, 123);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnsemua
            // 
            this.btnsemua.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsemua.Location = new System.Drawing.Point(435, 154);
            this.btnsemua.Name = "btnsemua";
            this.btnsemua.Size = new System.Drawing.Size(102, 46);
            this.btnsemua.TabIndex = 22;
            this.btnsemua.Text = "Semua";
            this.btnsemua.UseVisualStyleBackColor = false;
            this.btnsemua.Click += new System.EventHandler(this.btnsemua_Click_1);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnhapus.Location = new System.Drawing.Point(435, 231);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(102, 46);
            this.btnhapus.TabIndex = 23;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click_1);
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 438);
            this.Controls.Add(this.btnhapus);
            this.Controls.Add(this.btnsemua);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.transaksi);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLaporan";
            this.Text = "frmLaporan";
            this.Load += new System.EventHandler(this.frmLaporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox transaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsemua;
        private System.Windows.Forms.Button btnhapus;
    }
}
