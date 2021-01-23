using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyonu.ORM.Entity;
using OtelOtomasyonu.ORM.Facade;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class GirisYapForm : Form
    {
        public GirisYapForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            PersonellerORM pOrm = new PersonellerORM();
            Personeller p = new Personeller();
            p.KullaniciAdi = txtKullaniciAdi.Text;
            p.Parola = txtParola.Text;

            Personeller aktif = pOrm.GirisYap(p);
            if (aktif == null)
            {
                MessageBox.Show("Kullanıcı adı veya Parola Yanlış");
            }
            else
            {
                PersonellerORM.AktifKullanici = aktif;
                AnaForm af = new AnaForm();
                this.Hide();
                af.ShowDialog();
            }

        }

        private void GirisYapForm_Load(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
