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
    public partial class OdalarForm : Form
    {
        public OdalarForm()
        {
            InitializeComponent();
        }

        OdalarORM oOrm = new OdalarORM();
        OdaTurleriORM oTOrm = new OdaTurleriORM();
        private void OdalarForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = oOrm.Select();
            cmbOdaTuru.DataSource = oTOrm.Select();
            cmbOdaTuru.DisplayMember = "Adi";
            cmbOdaTuru.ValueMember = "Id";
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            Odalar o = new Odalar();
            o.Adi = txtIOdaAdi.Text;
            o.Aciklama = txtOdaAciklama.Text;
            o.OdaTurID = (int)cmbOdaTuru.SelectedValue;

            bool sonuc = oOrm.Insert(o);
            if (sonuc)
            {
                dataGridView1.DataSource = oOrm.Select();
                MessageBox.Show("Oda Ekleme Başarılı");
            }
            else
            {
                MessageBox.Show("Oda Eklenirken Hata Oluştu");
            }
            txtIOdaAdi.Clear();
            txtOdaAciklama.Clear();

        }
    }
}
