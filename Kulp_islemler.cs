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
using System.Data.OleDb;
using System.Collections;
namespace Sorumatik_Projesi
{
    public partial class Kulp_islemler : MetroForm
    {
        public Kulp_islemler()
        {
            InitializeComponent();
        }


        public db db3;
        string[] dersler = new string[10]{"Matematik","Geometri","Edebiyat","Dil Anlatım","Tarih","Coğrafya","Kimya","Fizik","Biyoloji","İnkılap"};
        private void Kulp_islemler_Load(object sender, EventArgs e)
        {
            if (db3.resim==9)
            {
                lbl_siniftext.Text = "9. SINIF KONULARI";
                db3.siniflar = "9_Sinif";
            }
           
            if (db3.resim == 10)
            {
                lbl_siniftext.Text = "10. SINIF KONULARI";
                db3.siniflar = "10_Sinif";
            }
            if (db3.resim == 11)
            {
                lbl_siniftext.Text = "11. SINIF KONULARI";
                db3.siniflar = "11_Sinif";
            }
            if (db3.resim == 12)
            {
                lbl_siniftext.Text = "12. SINIF KONULARI";
                db3.siniflar = "12_Sinif";
            }
            lbl_ders.Text = db3.dersler;
            
        }

        private void Kulp_islemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pb_sorularigetir_Click(object sender, EventArgs e)
        {
            pb_sorularigetir.Visible = false;
            pb_geri.Visible = true;


            db3.sorular(lb_cevaplar, txt_soru, label1, label3, label4, rb_cvpa, rb_cvpb, rb_cvpc, rb_cvpd, pb_pasgec,pb_devam);
            txt_soru.Text = db3.soru;
            rb_cvpa.Text = db3.cvp1;
            rb_cvpb.Text = db3.cvp2;
            rb_cvpc.Text = db3.cvp3;
            rb_cvpd.Text = db3.cvp4;
        }

        private void pb_devam_Click(object sender, EventArgs e)
        {
            if (rb_cvpa.Checked)
            {
                db3.cevablar.Add(1);
            }
            if (rb_cvpb.Checked)
            {
                db3.cevablar.Add(2);
            }
            if (rb_cvpc.Checked)
            {
                db3.cevablar.Add(3);
            }
            if (rb_cvpd.Checked)
            {
                db3.cevablar.Add(4);
            }
            
            db3.sorular(lb_cevaplar, txt_soru, label1, label3, label4, rb_cvpa, rb_cvpb, rb_cvpc, rb_cvpd, pb_pasgec, pb_devam);
            txt_soru.Text = db3.soru;
            rb_cvpa.Text = db3.cvp1;
            rb_cvpb.Text = db3.cvp2;
            rb_cvpc.Text = db3.cvp3;
            rb_cvpd.Text = db3.cvp4;
            label1.Visible = false;
        }

        private void pb_pasgec_Click(object sender, EventArgs e)
        {

        }

        private void pb_geri_Click(object sender, EventArgs e)
        {
            Kulp_sinif sinif3 = new Kulp_sinif();
            sinif3.Show();
            this.Hide();
        }
    }
 }

