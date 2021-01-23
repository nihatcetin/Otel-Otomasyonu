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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        MusteriORM mOrm = new MusteriORM();
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mOrm.Select();

            //Tanımladığımız enumları bize string dizisi olarak dönderecek.
            cmbMedeniDurum.DataSource = Enum.GetNames(typeof(MedeniDurumTip));
            cmbCinsiyet.DataSource = Enum.GetNames(typeof(Cinsiyet));
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteriler m = new Musteriler();
            m.Adi = txtAdi.Text;
            m.Soyadi = txtSoyadi.Text;
            m.SirketAdi = txtSirketAdi.Text;
            m.Tckn = mskdTckn.Text;
            m.TelNo = mskdTelefon.Text;
            m.DogumTarihi = dtpDogumTarihi.Value;
            m.MedeniDurumu =(MedeniDurumTip) Enum.Parse(typeof(MedeniDurumTip), cmbMedeniDurum.SelectedItem.ToString());
            m.Cinsiyet = (Cinsiyet)Enum.Parse(typeof(Cinsiyet), cmbCinsiyet.SelectedItem.ToString());

            bool sonuc = mOrm.Insert(m);
            if (sonuc)
            {
                dataGridView1.DataSource = mOrm.Select();
                MessageBox.Show("Müşteri Eklenmiştir.");
            }
            else
            {
                MessageBox.Show("Müşteri Eklerken Hata Oluştu");
            }
        }
    }
}
