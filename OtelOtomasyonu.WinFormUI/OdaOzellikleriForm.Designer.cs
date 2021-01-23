namespace OtelOtomasyonu.WinFormUI
{
    partial class OdaOzellikleriForm
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
            this.lblOdalar = new System.Windows.Forms.Label();
            this.lblDeger = new System.Windows.Forms.Label();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.cmbOdalar = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblOzellikler = new System.Windows.Forms.Label();
            this.listOzellikler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblOdalar
            // 
            this.lblOdalar.AutoSize = true;
            this.lblOdalar.Location = new System.Drawing.Point(12, 23);
            this.lblOdalar.Name = "lblOdalar";
            this.lblOdalar.Size = new System.Drawing.Size(44, 23);
            this.lblOdalar.TabIndex = 0;
            this.lblOdalar.Text = "Oda";
            // 
            // lblDeger
            // 
            this.lblDeger.AutoSize = true;
            this.lblDeger.Location = new System.Drawing.Point(489, 23);
            this.lblDeger.Name = "lblDeger";
            this.lblDeger.Size = new System.Drawing.Size(61, 23);
            this.lblDeger.TabIndex = 1;
            this.lblDeger.Text = "Değer";
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(493, 49);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(129, 29);
            this.txtDeger.TabIndex = 2;
            // 
            // cmbOdalar
            // 
            this.cmbOdalar.FormattingEnabled = true;
            this.cmbOdalar.Location = new System.Drawing.Point(12, 49);
            this.cmbOdalar.Name = "cmbOdalar";
            this.cmbOdalar.Size = new System.Drawing.Size(145, 30);
            this.cmbOdalar.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(493, 84);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(129, 41);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblOzellikler
            // 
            this.lblOzellikler.AutoSize = true;
            this.lblOzellikler.Location = new System.Drawing.Point(169, 23);
            this.lblOzellikler.Name = "lblOzellikler";
            this.lblOzellikler.Size = new System.Drawing.Size(83, 23);
            this.lblOzellikler.TabIndex = 6;
            this.lblOzellikler.Text = "Özellikler";
            // 
            // listOzellikler
            // 
            this.listOzellikler.FormattingEnabled = true;
            this.listOzellikler.ItemHeight = 22;
            this.listOzellikler.Location = new System.Drawing.Point(173, 49);
            this.listOzellikler.Name = "listOzellikler";
            this.listOzellikler.Size = new System.Drawing.Size(314, 444);
            this.listOzellikler.TabIndex = 7;
            // 
            // OdaOzellikleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 555);
            this.Controls.Add(this.listOzellikler);
            this.Controls.Add(this.lblOzellikler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbOdalar);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.lblDeger);
            this.Controls.Add(this.lblOdalar);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OdaOzellikleriForm";
            this.Text = "OdaOzellikleriForm";
            this.Load += new System.EventHandler(this.OdaOzellikleriForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOdalar;
        private System.Windows.Forms.Label lblDeger;
        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.ComboBox cmbOdalar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblOzellikler;
        private System.Windows.Forms.ListBox listOzellikler;
    }
}