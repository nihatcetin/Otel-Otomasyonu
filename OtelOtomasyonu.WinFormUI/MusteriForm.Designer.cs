namespace OtelOtomasyonu.WinFormUI
{
    partial class MusteriForm
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
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblSirketAdi = new System.Windows.Forms.Label();
            this.lblTckn = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMedeniDurum = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.mskdTckn = new System.Windows.Forms.MaskedTextBox();
            this.mskdTelefon = new System.Windows.Forms.MaskedTextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbMedeniDurum = new System.Windows.Forms.ComboBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(12, 9);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(36, 23);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Adı";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(147, 9);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(65, 23);
            this.lblSoyadi.TabIndex = 1;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // lblSirketAdi
            // 
            this.lblSirketAdi.AutoSize = true;
            this.lblSirketAdi.Location = new System.Drawing.Point(282, 9);
            this.lblSirketAdi.Name = "lblSirketAdi";
            this.lblSirketAdi.Size = new System.Drawing.Size(89, 23);
            this.lblSirketAdi.TabIndex = 2;
            this.lblSirketAdi.Text = "Şirket Adı";
            // 
            // lblTckn
            // 
            this.lblTckn.AutoSize = true;
            this.lblTckn.Location = new System.Drawing.Point(423, 9);
            this.lblTckn.Name = "lblTckn";
            this.lblTckn.Size = new System.Drawing.Size(56, 23);
            this.lblTckn.TabIndex = 3;
            this.lblTckn.Text = "TCKN";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(552, 9);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(72, 23);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMedeniDurum
            // 
            this.lblMedeniDurum.AutoSize = true;
            this.lblMedeniDurum.Location = new System.Drawing.Point(151, 83);
            this.lblMedeniDurum.Name = "lblMedeniDurum";
            this.lblMedeniDurum.Size = new System.Drawing.Size(135, 23);
            this.lblMedeniDurum.TabIndex = 5;
            this.lblMedeniDurum.Text = "Medeni Durum";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(16, 35);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(129, 29);
            this.txtAdi.TabIndex = 6;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(151, 35);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(129, 29);
            this.txtSoyadi.TabIndex = 7;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Location = new System.Drawing.Point(286, 35);
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(129, 29);
            this.txtSirketAdi.TabIndex = 8;
            // 
            // mskdTckn
            // 
            this.mskdTckn.Location = new System.Drawing.Point(421, 35);
            this.mskdTckn.Mask = "00000000000";
            this.mskdTckn.Name = "mskdTckn";
            this.mskdTckn.Size = new System.Drawing.Size(129, 29);
            this.mskdTckn.TabIndex = 9;
            // 
            // mskdTelefon
            // 
            this.mskdTelefon.Location = new System.Drawing.Point(556, 35);
            this.mskdTelefon.Mask = "(999) 000-0000";
            this.mskdTelefon.Name = "mskdTelefon";
            this.mskdTelefon.Size = new System.Drawing.Size(129, 29);
            this.mskdTelefon.TabIndex = 10;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(16, 107);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(129, 29);
            this.dtpDogumTarihi.TabIndex = 11;
            // 
            // cmbMedeniDurum
            // 
            this.cmbMedeniDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniDurum.FormattingEnabled = true;
            this.cmbMedeniDurum.Location = new System.Drawing.Point(151, 109);
            this.cmbMedeniDurum.Name = "cmbMedeniDurum";
            this.cmbMedeniDurum.Size = new System.Drawing.Size(129, 30);
            this.cmbMedeniDurum.TabIndex = 12;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Location = new System.Drawing.Point(286, 109);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(129, 30);
            this.cmbCinsiyet.TabIndex = 13;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(288, 83);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(73, 23);
            this.lblCinsiyet.TabIndex = 14;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 80);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(124, 23);
            this.lblDogumTarihi.TabIndex = 15;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(421, 107);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 34);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1502, 454);
            this.dataGridView1.TabIndex = 17;
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1530, 611);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.cmbMedeniDurum);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.mskdTelefon);
            this.Controls.Add(this.mskdTckn);
            this.Controls.Add(this.txtSirketAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblMedeniDurum);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTckn);
            this.Controls.Add(this.lblSirketAdi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusteriForm";
            this.Text = "MusteriForm";
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblSirketAdi;
        private System.Windows.Forms.Label lblTckn;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMedeniDurum;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.MaskedTextBox mskdTckn;
        private System.Windows.Forms.MaskedTextBox mskdTelefon;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cmbMedeniDurum;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}