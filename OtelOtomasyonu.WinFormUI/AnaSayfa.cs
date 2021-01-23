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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        BirimTipForm bt = new BirimTipForm();
        private void birimTipleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (bt.IsDisposed)
            {
                bt = new BirimTipForm();
            }
            bt.MdiParent = this;
            bt.Show();
        }
        KasaForm kf = new KasaForm();
        private void kasaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (kf.IsDisposed)
            {
                kf = new KasaForm();
            }

            kf.MdiParent = this;
            kf.Show();
        }

        KategoriForm ktgf = new KategoriForm();
        private void kategorilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ktgf.IsDisposed)
            {
                ktgf = new KategoriForm();
            }

            ktgf.MdiParent = this;
            ktgf.Show();
        }

        UrunlerForm uf = new UrunlerForm();
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (uf.IsDisposed)
            {
                uf = new UrunlerForm();
            }

            uf.MdiParent = this;
            uf.Show();
        }

        OdaTurleriForm otf = new OdaTurleriForm();
        private void odaTürleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (otf.IsDisposed)
            {
                otf = new OdaTurleriForm();
            }

            otf.MdiParent = this;
            otf.Show();
        }
        OdalarForm of = new OdalarForm();
        private void odalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (of.IsDisposed)
            {
                of = new OdalarForm();

            }
            of.MdiParent = this;
            of.Show();
            
        }

        OzelliklerForm ozelliklerForm = new OzelliklerForm();
        private void özelliklerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ozelliklerForm.IsDisposed)
            {
                ozelliklerForm = new OzelliklerForm();
            }

            ozelliklerForm.MdiParent = this;
            ozelliklerForm.Show();
        }
        OdaOzellikleriForm odaOzF = new OdaOzellikleriForm();
        private void odaÖzellikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odaOzF.IsDisposed)
            {
                odaOzF = new OdaOzellikleriForm();
            }

            odaOzF.MdiParent = this;
            odaOzF.Show();
        }
        MusteriForm mf = new MusteriForm();
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mf.IsDisposed)
            {
                mf = new MusteriForm();
            }

            mf.MdiParent = this;
            mf.Show();
        }

        PersonellerForm pf = new PersonellerForm();
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pf.IsDisposed)
                pf = new PersonellerForm();
            pf.MdiParent = this;
            pf.Show();
        }
        SatisForm sf = new SatisForm();
        private void satışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sf.IsDisposed)
            {
                sf = new SatisForm();
            }

            sf.MdiParent = this;
            sf.Show();
        }
    }
}
