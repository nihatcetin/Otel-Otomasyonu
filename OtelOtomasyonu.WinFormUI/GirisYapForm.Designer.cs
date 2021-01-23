namespace OtelOtomasyonu.WinFormUI
{
    partial class GirisYapForm
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
            this.lblOtelOtomasyonu = new System.Windows.Forms.Label();
            this.lblGirisYap = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblOtelOtomasyonu
            // 
            this.lblOtelOtomasyonu.AutoSize = true;
            this.lblOtelOtomasyonu.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOtelOtomasyonu.Location = new System.Drawing.Point(79, 69);
            this.lblOtelOtomasyonu.Name = "lblOtelOtomasyonu";
            this.lblOtelOtomasyonu.Size = new System.Drawing.Size(291, 36);
            this.lblOtelOtomasyonu.TabIndex = 0;
            this.lblOtelOtomasyonu.Text = "OTEL OTOMASYONU";
            // 
            // lblGirisYap
            // 
            this.lblGirisYap.AutoSize = true;
            this.lblGirisYap.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisYap.Location = new System.Drawing.Point(191, 138);
            this.lblGirisYap.Name = "lblGirisYap";
            this.lblGirisYap.Size = new System.Drawing.Size(107, 29);
            this.lblGirisYap.TabIndex = 1;
            this.lblGirisYap.Text = "Giriş Yap";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(81, 217);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(110, 23);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(129, 260);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(61, 23);
            this.lblParola.TabIndex = 3;
            this.lblParola.Text = "Parola";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(198, 214);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(137, 29);
            this.txtKullaniciAdi.TabIndex = 4;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(196, 257);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(139, 29);
            this.txtParola.TabIndex = 5;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(214, 303);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(121, 38);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // GirisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 484);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblGirisYap);
            this.Controls.Add(this.lblOtelOtomasyonu);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GirisYapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisYapForm";
            this.Load += new System.EventHandler(this.GirisYapForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOtelOtomasyonu;
        private System.Windows.Forms.Label lblGirisYap;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnGirisYap;
    }
}