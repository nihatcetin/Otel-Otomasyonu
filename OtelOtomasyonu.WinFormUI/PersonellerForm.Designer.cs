namespace OtelOtomasyonu.WinFormUI
{
    partial class PersonellerForm
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
            this.lblTckn = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.mskdTckn = new System.Windows.Forms.MaskedTextBox();
            this.mskdTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblIseGirisTarihi = new System.Windows.Forms.Label();
            this.dtpIseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblMaas = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
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
            this.lblSoyadi.Location = new System.Drawing.Point(144, 9);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(65, 23);
            this.lblSoyadi.TabIndex = 1;
            this.lblSoyadi.Text = "Soyadı";
            // 
            // lblTckn
            // 
            this.lblTckn.AutoSize = true;
            this.lblTckn.Location = new System.Drawing.Point(262, 9);
            this.lblTckn.Name = "lblTckn";
            this.lblTckn.Size = new System.Drawing.Size(50, 23);
            this.lblTckn.TabIndex = 2;
            this.lblTckn.Text = "Tckn";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(387, 9);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(64, 23);
            this.lblTelNo.TabIndex = 3;
            this.lblTelNo.Text = "Tel No";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 85);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(124, 23);
            this.lblDogumTarihi.TabIndex = 4;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(521, 9);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(57, 23);
            this.lblAdres.TabIndex = 5;
            this.lblAdres.Text = "Adres";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(521, 85);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(61, 23);
            this.lblParola.TabIndex = 6;
            this.lblParola.Text = "Parola";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(16, 35);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(119, 29);
            this.txtAdi.TabIndex = 7;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(141, 35);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(119, 29);
            this.txtSoyadi.TabIndex = 7;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(392, 113);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(119, 29);
            this.txtKullaniciAdi.TabIndex = 7;
            // 
            // mskdTckn
            // 
            this.mskdTckn.Location = new System.Drawing.Point(266, 35);
            this.mskdTckn.Mask = "00000000000";
            this.mskdTckn.Name = "mskdTckn";
            this.mskdTckn.Size = new System.Drawing.Size(119, 29);
            this.mskdTckn.TabIndex = 8;
            // 
            // mskdTelNo
            // 
            this.mskdTelNo.Location = new System.Drawing.Point(391, 35);
            this.mskdTelNo.Mask = "(999) 000-0000";
            this.mskdTelNo.Name = "mskdTelNo";
            this.mskdTelNo.Size = new System.Drawing.Size(119, 29);
            this.mskdTelNo.TabIndex = 8;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(516, 35);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(238, 47);
            this.txtAdres.TabIndex = 7;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(16, 111);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(119, 29);
            this.dtpDogumTarihi.TabIndex = 10;
            // 
            // lblIseGirisTarihi
            // 
            this.lblIseGirisTarihi.AutoSize = true;
            this.lblIseGirisTarihi.Location = new System.Drawing.Point(144, 85);
            this.lblIseGirisTarihi.Name = "lblIseGirisTarihi";
            this.lblIseGirisTarihi.Size = new System.Drawing.Size(117, 23);
            this.lblIseGirisTarihi.TabIndex = 4;
            this.lblIseGirisTarihi.Text = "İşe Giriş Tar.";
            // 
            // dtpIseGirisTarihi
            // 
            this.dtpIseGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIseGirisTarihi.Location = new System.Drawing.Point(141, 111);
            this.dtpIseGirisTarihi.Name = "dtpIseGirisTarihi";
            this.dtpIseGirisTarihi.Size = new System.Drawing.Size(119, 29);
            this.dtpIseGirisTarihi.TabIndex = 10;
            // 
            // nudMaas
            // 
            this.nudMaas.Location = new System.Drawing.Point(266, 111);
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(120, 29);
            this.nudMaas.TabIndex = 11;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(517, 113);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(119, 29);
            this.txtParola.TabIndex = 7;
            // 
            // lblMaas
            // 
            this.lblMaas.AutoSize = true;
            this.lblMaas.Location = new System.Drawing.Point(262, 85);
            this.lblMaas.Name = "lblMaas";
            this.lblMaas.Size = new System.Drawing.Size(57, 23);
            this.lblMaas.TabIndex = 6;
            this.lblMaas.Text = "Maaşı";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(388, 85);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(110, 23);
            this.lblKullaniciAdi.TabIndex = 6;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(642, 108);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 38);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(738, 346);
            this.dataGridView1.TabIndex = 13;
            // 
            // PersonellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 503);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudMaas);
            this.Controls.Add(this.dtpIseGirisTarihi);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.mskdTelNo);
            this.Controls.Add(this.mskdTckn);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.lblMaas);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblIseGirisTarihi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblTelNo);
            this.Controls.Add(this.lblTckn);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PersonellerForm";
            this.Text = "PersonellerForm";
            this.Load += new System.EventHandler(this.PersonellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblTckn;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.MaskedTextBox mskdTckn;
        private System.Windows.Forms.MaskedTextBox mskdTelNo;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label lblIseGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpIseGirisTarihi;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblMaas;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}