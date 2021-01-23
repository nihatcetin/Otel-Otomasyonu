namespace OtelOtomasyonu.WinFormUI
{
    partial class OdalarForm
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
            this.lblOdaAdi = new System.Windows.Forms.Label();
            this.lblOdaAciklama = new System.Windows.Forms.Label();
            this.lblOdaTuru = new System.Windows.Forms.Label();
            this.txtIOdaAdi = new System.Windows.Forms.TextBox();
            this.txtOdaAciklama = new System.Windows.Forms.TextBox();
            this.cmbOdaTuru = new System.Windows.Forms.ComboBox();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOdaAdi
            // 
            this.lblOdaAdi.AutoSize = true;
            this.lblOdaAdi.Location = new System.Drawing.Point(12, 21);
            this.lblOdaAdi.Name = "lblOdaAdi";
            this.lblOdaAdi.Size = new System.Drawing.Size(76, 23);
            this.lblOdaAdi.TabIndex = 0;
            this.lblOdaAdi.Text = "Oda Adı";
            // 
            // lblOdaAciklama
            // 
            this.lblOdaAciklama.AutoSize = true;
            this.lblOdaAciklama.Location = new System.Drawing.Point(12, 57);
            this.lblOdaAciklama.Name = "lblOdaAciklama";
            this.lblOdaAciklama.Size = new System.Drawing.Size(83, 23);
            this.lblOdaAciklama.TabIndex = 1;
            this.lblOdaAciklama.Text = "Aciklama";
            // 
            // lblOdaTuru
            // 
            this.lblOdaTuru.AutoSize = true;
            this.lblOdaTuru.Location = new System.Drawing.Point(12, 91);
            this.lblOdaTuru.Name = "lblOdaTuru";
            this.lblOdaTuru.Size = new System.Drawing.Size(90, 23);
            this.lblOdaTuru.TabIndex = 2;
            this.lblOdaTuru.Text = "Oda Türü";
            // 
            // txtIOdaAdi
            // 
            this.txtIOdaAdi.Location = new System.Drawing.Point(108, 21);
            this.txtIOdaAdi.Name = "txtIOdaAdi";
            this.txtIOdaAdi.Size = new System.Drawing.Size(137, 29);
            this.txtIOdaAdi.TabIndex = 3;
            // 
            // txtOdaAciklama
            // 
            this.txtOdaAciklama.Location = new System.Drawing.Point(108, 57);
            this.txtOdaAciklama.Name = "txtOdaAciklama";
            this.txtOdaAciklama.Size = new System.Drawing.Size(137, 29);
            this.txtOdaAciklama.TabIndex = 4;
            // 
            // cmbOdaTuru
            // 
            this.cmbOdaTuru.FormattingEnabled = true;
            this.cmbOdaTuru.Location = new System.Drawing.Point(108, 92);
            this.cmbOdaTuru.Name = "cmbOdaTuru";
            this.cmbOdaTuru.Size = new System.Drawing.Size(137, 30);
            this.cmbOdaTuru.TabIndex = 5;
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.Location = new System.Drawing.Point(139, 139);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(106, 37);
            this.btnOdaEkle.TabIndex = 6;
            this.btnOdaEkle.Text = "Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = true;
            this.btnOdaEkle.Click += new System.EventHandler(this.btnOdaEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // OdalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOdaEkle);
            this.Controls.Add(this.cmbOdaTuru);
            this.Controls.Add(this.txtOdaAciklama);
            this.Controls.Add(this.txtIOdaAdi);
            this.Controls.Add(this.lblOdaTuru);
            this.Controls.Add(this.lblOdaAciklama);
            this.Controls.Add(this.lblOdaAdi);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdalarForm";
            this.Text = "OdalarForm";
            this.Load += new System.EventHandler(this.OdalarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdaAdi;
        private System.Windows.Forms.Label lblOdaAciklama;
        private System.Windows.Forms.Label lblOdaTuru;
        private System.Windows.Forms.TextBox txtIOdaAdi;
        private System.Windows.Forms.TextBox txtOdaAciklama;
        private System.Windows.Forms.ComboBox cmbOdaTuru;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}