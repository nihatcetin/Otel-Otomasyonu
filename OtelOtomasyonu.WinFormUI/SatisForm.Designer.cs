namespace OtelOtomasyonu.WinFormUI
{
    partial class SatisForm
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
            this.lblMusteri = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.lblOda = new System.Windows.Forms.Label();
            this.cmbOda = new System.Windows.Forms.ComboBox();
            this.lblOdaFiyati = new System.Windows.Forms.Label();
            this.nudOdaFiyati = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUrunMiktari = new System.Windows.Forms.Label();
            this.nudUrunMiktari = new System.Windows.Forms.NumericUpDown();
            this.lblUrunFiyati = new System.Windows.Forms.Label();
            this.nudUrunFiyati = new System.Windows.Forms.NumericUpDown();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSatisaEkle = new System.Windows.Forms.Button();
            this.listview1 = new System.Windows.Forms.ListView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(8, 13);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(71, 23);
            this.lblMusteri.TabIndex = 0;
            this.lblMusteri.Text = "Müşteri";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(12, 40);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(136, 30);
            this.cmbMusteri.TabIndex = 1;
            // 
            // lblOda
            // 
            this.lblOda.AutoSize = true;
            this.lblOda.Location = new System.Drawing.Point(150, 13);
            this.lblOda.Name = "lblOda";
            this.lblOda.Size = new System.Drawing.Size(44, 23);
            this.lblOda.TabIndex = 0;
            this.lblOda.Text = "Oda";
            // 
            // cmbOda
            // 
            this.cmbOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOda.FormattingEnabled = true;
            this.cmbOda.Location = new System.Drawing.Point(154, 40);
            this.cmbOda.Name = "cmbOda";
            this.cmbOda.Size = new System.Drawing.Size(136, 30);
            this.cmbOda.TabIndex = 1;
            // 
            // lblOdaFiyati
            // 
            this.lblOdaFiyati.AutoSize = true;
            this.lblOdaFiyati.Location = new System.Drawing.Point(299, 13);
            this.lblOdaFiyati.Name = "lblOdaFiyati";
            this.lblOdaFiyati.Size = new System.Drawing.Size(93, 23);
            this.lblOdaFiyati.TabIndex = 0;
            this.lblOdaFiyati.Text = "Oda Fiyatı";
            // 
            // nudOdaFiyati
            // 
            this.nudOdaFiyati.Location = new System.Drawing.Point(296, 41);
            this.nudOdaFiyati.Name = "nudOdaFiyati";
            this.nudOdaFiyati.Size = new System.Drawing.Size(120, 29);
            this.nudOdaFiyati.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(586, 418);
            this.dataGridView1.TabIndex = 3;
            // 
            // lblUrunMiktari
            // 
            this.lblUrunMiktari.AutoSize = true;
            this.lblUrunMiktari.Location = new System.Drawing.Point(621, 141);
            this.lblUrunMiktari.Name = "lblUrunMiktari";
            this.lblUrunMiktari.Size = new System.Drawing.Size(112, 23);
            this.lblUrunMiktari.TabIndex = 4;
            this.lblUrunMiktari.Text = "Ürün Miktari";
            // 
            // nudUrunMiktari
            // 
            this.nudUrunMiktari.Location = new System.Drawing.Point(621, 167);
            this.nudUrunMiktari.Name = "nudUrunMiktari";
            this.nudUrunMiktari.Size = new System.Drawing.Size(120, 29);
            this.nudUrunMiktari.TabIndex = 2;
            // 
            // lblUrunFiyati
            // 
            this.lblUrunFiyati.AutoSize = true;
            this.lblUrunFiyati.Location = new System.Drawing.Point(617, 213);
            this.lblUrunFiyati.Name = "lblUrunFiyati";
            this.lblUrunFiyati.Size = new System.Drawing.Size(100, 23);
            this.lblUrunFiyati.TabIndex = 4;
            this.lblUrunFiyati.Text = "Ürün Fiyatı";
            // 
            // nudUrunFiyati
            // 
            this.nudUrunFiyati.Location = new System.Drawing.Point(621, 238);
            this.nudUrunFiyati.Name = "nudUrunFiyati";
            this.nudUrunFiyati.Size = new System.Drawing.Size(120, 29);
            this.nudUrunFiyati.TabIndex = 2;
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(617, 284);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(70, 23);
            this.lblIndirim.TabIndex = 4;
            this.lblIndirim.Text = "İndirim";
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(621, 309);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(120, 29);
            this.nudIndirim.TabIndex = 2;
            // 
            // btnSatisaEkle
            // 
            this.btnSatisaEkle.Location = new System.Drawing.Point(621, 359);
            this.btnSatisaEkle.Name = "btnSatisaEkle";
            this.btnSatisaEkle.Size = new System.Drawing.Size(120, 43);
            this.btnSatisaEkle.TabIndex = 5;
            this.btnSatisaEkle.Text = "Satışa Ekle";
            this.btnSatisaEkle.UseVisualStyleBackColor = true;
            this.btnSatisaEkle.Click += new System.EventHandler(this.btnSatisaEkle_Click);
            // 
            // listview1
            // 
            this.listview1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listview1.FullRowSelect = true;
            this.listview1.GridLines = true;
            this.listview1.Location = new System.Drawing.Point(783, 87);
            this.listview1.Name = "listview1";
            this.listview1.Size = new System.Drawing.Size(672, 418);
            this.listview1.TabIndex = 6;
            this.listview1.UseCompatibleStateImageBehavior = false;
            this.listview1.View = System.Windows.Forms.View.Details;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1092, 521);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(112, 41);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra No";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 94;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktar";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İndirim";
            this.columnHeader5.Width = 137;
            // 
            // SatisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 632);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.listview1);
            this.Controls.Add(this.btnSatisaEkle);
            this.Controls.Add(this.lblIndirim);
            this.Controls.Add(this.lblUrunFiyati);
            this.Controls.Add(this.nudIndirim);
            this.Controls.Add(this.nudUrunFiyati);
            this.Controls.Add(this.lblUrunMiktari);
            this.Controls.Add(this.nudUrunMiktari);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nudOdaFiyati);
            this.Controls.Add(this.cmbOda);
            this.Controls.Add(this.lblOdaFiyati);
            this.Controls.Add(this.lblOda);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.lblMusteri);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SatisForm";
            this.Text = "SatisForm";
            this.Load += new System.EventHandler(this.SatisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudOdaFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label lblOda;
        private System.Windows.Forms.ComboBox cmbOda;
        private System.Windows.Forms.Label lblOdaFiyati;
        private System.Windows.Forms.NumericUpDown nudOdaFiyati;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrunMiktari;
        private System.Windows.Forms.NumericUpDown nudUrunMiktari;
        private System.Windows.Forms.Label lblUrunFiyati;
        private System.Windows.Forms.NumericUpDown nudUrunFiyati;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.NumericUpDown nudIndirim;
        private System.Windows.Forms.Button btnSatisaEkle;
        private System.Windows.Forms.ListView listview1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnKaydet;
    }
}