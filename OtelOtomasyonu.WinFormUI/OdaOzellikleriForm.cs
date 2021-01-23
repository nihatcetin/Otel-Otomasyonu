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
using OzelliklerORM = OtelOtomasyonu.ORM.Facade.OzelliklerORM;

namespace OtelOtomasyonu.WinFormUI
{
    public partial class OdaOzellikleriForm : Form
    {
        public OdaOzellikleriForm()
        {
            InitializeComponent();
        }

        private void OdaOzellikleriForm_Load(object sender, EventArgs e)
        {
            OdalarORM odaOrm = new OdalarORM();
            cmbOdalar.DataSource = odaOrm.Select();
            cmbOdalar.DisplayMember = "Adi";
            cmbOdalar.ValueMember = "Id";

            OzelliklerORM ozOrm = new OzelliklerORM();


            listOzellikler.DataSource = ozOrm.Select();
            listOzellikler.DisplayMember = "Adi";
            listOzellikler.ValueMember = "Id";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaOzellikleriORM odaOzellikleriOrm = new OdaOzellikleriORM();
            OdaOzellikleri odaOzellikleri = new OdaOzellikleri();

            odaOzellikleri.OdaID = (int)cmbOdalar.SelectedValue;
            odaOzellikleri.OzellikID = (int)listOzellikler.SelectedValue;
            //tryparse:Metodun kullanım amacı gönderilen değerin ilgili türe dönüşüp dönüşemeyeğini belirlemektir. TryParse metodu geriye bool tipinde değer döndürmektedir.
            short deger;
            if (short.TryParse(txtDeger.Text, out deger))
            {
                odaOzellikleri.Deger = deger;
            }

            bool sonuc = odaOzellikleriOrm.Insert(odaOzellikleri);
            if (sonuc)
            {
                MessageBox.Show("Odaya Seçilen Özellik Eklenmiştir");
            }
            else
            {
                MessageBox.Show("Odaye Özellik Eklenirken Hata Oluştu ");
            }
        }
    }
}
