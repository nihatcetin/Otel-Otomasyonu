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
    public partial class KasaForm : Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }
        
        KasaORM kOrm = new KasaORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kasa k = new Kasa();
            k.Adi = txtKasaAdi.Text;
            k.Aciklama = txtAciklama.Text;
            bool sonuc = kOrm.Insert(k);

            if (sonuc)
            {
                MessageBox.Show("Kasa Eklendi");
                dataGridView1.DataSource = kOrm.Select();
            }
            else
            {
                MessageBox.Show("Kasa Eklenirken Hata Oluştu");
            }

        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kOrm.Select();
        }
    }
}
