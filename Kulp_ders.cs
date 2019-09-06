using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorumatik_Projesi
{
    public partial class Kulp_ders : MetroForm
    {
        public Kulp_ders()
        {
            InitializeComponent();
        }
        Kulp_islemler klpislm = new Kulp_islemler();
        public db db2;

        private void pb_matematik_Click(object sender, EventArgs e)
        {
            db2.dersler = "Matematik";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_biyoloji_Click(object sender, EventArgs e)
        {
            db2.dersler = "Biyoloji";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_fizik_Click(object sender, EventArgs e)
        {
            db2.dersler = "Fizik";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_kimya_Click(object sender, EventArgs e)
        {
            db2.dersler = "Kimya";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_edebiyat_Click(object sender, EventArgs e)
        {
            db2.dersler = "Edebiyat";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_dila_Click(object sender, EventArgs e)
        {
            db2.dersler = "Dil Anlatım";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_geometri_Click(object sender, EventArgs e)
        {
            db2.dersler = "Geometri";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_tarih_Click(object sender, EventArgs e)
        {
            db2.dersler = "Tarih";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_inkilap_Click(object sender, EventArgs e)
        {
            db2.dersler = "İnkılap";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void pb_cograyfa_Click(object sender, EventArgs e)
        {
            db2.dersler = "Coğrafya";
            klpislm.db3 = db2;
            klpislm.Show();
            this.Hide();
        }

        private void Kulp_ders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pb_geri_Click(object sender, EventArgs e)
        {
            Kulp_sinif anafrm = new Kulp_sinif();
            anafrm.Show();
            this.Hide();
        }
    }
}
