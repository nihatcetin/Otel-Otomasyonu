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
    public partial class OdaTurleriForm : Form
    {
        public OdaTurleriForm()
        {
            InitializeComponent();
        }
        OdaTurleriORM oTOrm = new OdaTurleriORM();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            OdaTurleri oT = new OdaTurleri();
            oT.Adi = txtAdi.Text;
            oT.Aciklama = txtAciklama.Text;
            bool sonuc = oTOrm.Insert(oT);
            if (sonuc)
            {
                MessageBox.Show("Oda Türü Eklendi");
                dataGridView1.DataSource = oTOrm.Select();
            }
            else
            {
                MessageBox.Show("Oda Tür Eklenirken Hata Oluştu");
            }
        }

        private void OdaTurleriForm_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = oTOrm.Select();
        }
    }
}
