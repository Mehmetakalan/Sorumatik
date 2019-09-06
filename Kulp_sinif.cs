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
    public partial class Kulp_sinif : MetroForm
    {
        public Kulp_sinif()
        {
            InitializeComponent();
        }
        db db1=new db();
        Kulp_ders klpders = new Kulp_ders();

        private void Kulp_sinif_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Kulp_sinif_Load(object sender, EventArgs e)
        {

        }

        private void Sinif10_Click(object sender, EventArgs e)
        {
            db1.resim = 10;
            klpders.db2 = db1;
            klpders.Show();
            this.Hide();
        }

        private void Sinif9_Click(object sender, EventArgs e)
        {
            db1.resim = 9;
            klpders.db2 = db1;
            klpders.Show();
            this.Hide();
        }

        private void Sinif12_Click(object sender, EventArgs e)
        {
            db1.resim = 12;
            klpders.db2 = db1;
            klpders.Show();
            this.Hide();
        }

        private void Sinif11_Click(object sender, EventArgs e)
        {
            db1.resim = 11;
            klpders.db2 = db1;
            klpders.Show();
            this.Hide();
        }

        private void ButonGeri_Click(object sender, EventArgs e)
        {
            anaform anafrm=new anaform();
            anafrm.Show();
            this.Hide();
        }
    }
}
