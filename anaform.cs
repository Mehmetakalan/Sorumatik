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
    public partial class anaform : MetroForm
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            db db = new db();
            db.baglanti.Close();
        }

        private void YoneticiPaneli_Click(object sender, EventArgs e)
        {
            yonetici_paneli frm = new yonetici_paneli();
            frm.Show();
            this.Hide();
        }

        private void KullaniciPaneli_Click(object sender, EventArgs e)
        {
            Kulp_sinif frm2 = new Kulp_sinif();
            frm2.Show();
            this.Hide();
        }



        private void pb_destek_Click(object sender, EventArgs e)
        {
             // Paypal hesabı kullanılmamaktadır. Temsili olarak gösterilmiştir. 
            System.Diagnostics.Process.Start("https://goo.gl/BtWHGB");
            
        }

        private void pb_bizkimiz_Click(object sender, EventArgs e)
        {
            BizKimiz frm2 = new BizKimiz();
            this.Hide();
            frm2.Show();
            
        }
    }
}
