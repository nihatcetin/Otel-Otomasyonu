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
    public partial class KategoriForm : Form
    {
        public KategoriForm()
        {
            InitializeComponent();
        }
        KategoriORM korm = new KategoriORM();
        private void KategoriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = korm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.Adi = txtKategoriler.Text;
            bool sonuc = korm.Insert(k);
            if (sonuc)
            {
                MessageBox.Show("Kategori Eklenmiştir.");
                dataGridView1.DataSource = korm.Select();
            }
            else
            {
                MessageBox.Show("Kategori Eklenirken Hata Oluştu");
            }
        }
    }
}
