namespace OtelOtomasyonu.WinFormUI
{
    partial class UrunlerForm
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
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nudFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudMiktar = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbBirimTip = new System.Windows.Forms.ComboBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblBirimTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(8, 9);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(83, 23);
            this.lblUrunAdi.TabIndex = 0;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(12, 35);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(131, 29);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // nudFiyat
            // 
            this.nudFiyat.Location = new System.Drawing.Point(168, 35);
            this.nudFiyat.Name = "nudFiyat";
            this.nudFiyat.Size = new System.Drawing.Size(120, 29);
            this.nudFiyat.TabIndex = 2;
            // 
            // nudMiktar
            // 
            this.nudMiktar.Location = new System.Drawing.Point(311, 36);
            this.nudMiktar.Name = "nudMiktar";
            this.nudMiktar.Size = new System.Drawing.Size(120, 29);
            this.nudMiktar.TabIndex = 3;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(164, 9);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(49, 23);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Miktar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 352);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(725, 32);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(107, 34);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(448, 34);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 30);
            this.cmbKategori.TabIndex = 7;
            // 
            // cmbBirimTip
            // 
            this.cmbBirimTip.FormattingEnabled = true;
            this.cmbBirimTip.Location = new System.Drawing.Point(586, 34);
            this.cmbBirimTip.Name = "cmbBirimTip";
            this.cmbBirimTip.Size = new System.Drawing.Size(121, 30);
            this.cmbBirimTip.TabIndex = 7;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(444, 8);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(79, 23);
            this.lblKategori.TabIndex = 0;
            this.lblKategori.Text = "Kategori";
            // 
            // lblBirimTip
            // 
            this.lblBirimTip.AutoSize = true;
            this.lblBirimTip.Location = new System.Drawing.Point(582, 8);
            this.lblBirimTip.Name = "lblBirimTip";
            this.lblBirimTip.Size = new System.Drawing.Size(84, 23);
            this.lblBirimTip.TabIndex = 0;
            this.lblBirimTip.Text = "Birim Tip";
            // 
            // UrunlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 442);
            this.Controls.Add(this.cmbBirimTip);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nudMiktar);
            this.Controls.Add(this.nudFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblBirimTip);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblUrunAdi);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UrunlerForm";
            this.Text = "UrunlerForm";
            this.Load += new System.EventHandler(this.UrunlerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.NumericUpDown nudFiyat;
        private System.Windows.Forms.NumericUpDown nudMiktar;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ComboBox cmbBirimTip;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblBirimTip;
    }
}