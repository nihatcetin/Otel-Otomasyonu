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
    public partial class UrunlerForm : Form
    {
        public UrunlerForm()
        {
            InitializeComponent();
        }
        UrunlerORM uOrm = new UrunlerORM();
        private void UrunlerForm_Load(object sender, EventArgs e)
        {
            KategoriORM kOrm = new KategoriORM();
            cmbKategori.DataSource = kOrm.Select();
            cmbKategori.ValueMember = "Id";
            cmbKategori.DisplayMember = "Adi";
            BirimTipORM bOrm = new BirimTipORM();
            cmbBirimTip.DataSource = bOrm.Select();
            cmbBirimTip.ValueMember = "Id";
            cmbBirimTip.DisplayMember = "Adi";

            dataGridView1.DataSource = uOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.Adi = txtUrunAdi.Text;
            u.Fiyat = Convert.ToDouble(nudFiyat.Value);
            u.Miktar =Convert.ToDouble(nudMiktar.Value);
            u.BirimTipID = (int) cmbKategori.SelectedValue;
            u.KategoriID = (int) cmbBirimTip.SelectedValue;

            bool sonuc = uOrm.Insert(u);
            if (sonuc)
            {
                MessageBox.Show("Ürün Eklenmiştir");
                dataGridView1.DataSource = uOrm.Select();
            }
            else
            {
                MessageBox.Show("Ürün Eklenirken Hata Oluştu");
            }

        }
    }
}
