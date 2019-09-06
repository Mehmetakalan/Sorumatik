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
    public partial class yonetici_paneli : MetroForm
    {
        public yonetici_paneli()
        {
            InitializeComponent();
        }

        db db = new db();

        private void pb_giris_Click(object sender, EventArgs e)
        {
            db.giris(txt_gid.Text, txt_gsif.Text);
            if (db.durum == true)
            {
                this.Hide();
            }
            else
            {
                txt_gid.Clear();
                txt_gsif.Clear();
                txt_gid.Focus();
            }
        }

        private void pb_geri_Click(object sender, EventArgs e)
        {
            anaform frm = new anaform();
            frm.Show();
            this.Hide();
        }

        private void yonetici_paneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
