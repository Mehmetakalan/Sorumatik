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
    public partial class BizKimiz : MetroForm
    {
        public BizKimiz()
        {
            InitializeComponent();
        }

        private void BizKimiz_Load(object sender, EventArgs e)
        {

        }
        private void BizKimiz_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pb_geri_Click(object sender, EventArgs e)
        {
            anaform anafrm = new anaform();
            anafrm.Show();
            this.Hide();
        }

        private void pb_mehmet_MouseHover(object sender, EventArgs e)
        {
            pb_kartvizit.Image = Properties.Resources.MehmetOn;
        }

        private void pb_salim_MouseHover(object sender, EventArgs e)
        {
            pb_kartvizit.Image = Properties.Resources.SalimOn;
        }

        private void pb_salim_MouseLeave(object sender, EventArgs e)
        {
            pb_kartvizit.Image = Properties.Resources.SalimArka;
        }

        private void pb_mehmet_MouseLeave(object sender, EventArgs e)
        {
            pb_kartvizit.Image = Properties.Resources.MehmetArka;
        }
    }
}
