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

namespace OtelOtomasyonu.WinFormUI
{
    public partial class OzelliklerForm : Form
    {
        public OzelliklerForm()
        {
            InitializeComponent();
        }
        OzelliklerORM ozelliklerOrm = new OzelliklerORM();
        private void OzelliklerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ozelliklerOrm.Select();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ozellikler ozellikler = new Ozellikler();

            ozellikler.Adi = txtAdi.Text;
            ozellikler.Aciklama = txtAciklama.Text;
            bool sonuc = ozelliklerOrm.Insert(ozellikler);

            if (sonuc)
            {
                dataGridView1.DataSource = ozelliklerOrm.Select();
                MessageBox.Show("Ozellik Eklendi");
            }
            else
            {
                MessageBox.Show("Özellik Eklenirken Hata Oluştu");
            }

        }
    }
}
