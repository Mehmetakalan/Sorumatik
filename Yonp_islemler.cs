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

namespace Sorumatik_Projesi
{
    public partial class Yonp_islemler : MetroForm
    {
        public Yonp_islemler()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        db db = new db();

        private void Yonp_islemler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Yonp_islemler_Load(object sender, EventArgs e)
        {
        }

        private void pb_geri_Click(object sender, EventArgs e)
        {
            yonetici_paneli frm = new yonetici_paneli();
            frm.Show();
            this.Hide();
        }

        private void pb_ekle_Click(object sender, EventArgs e)
        {
            int dogrucevap = 0;
            if (rdb_cvpa.Checked)
            {
                dogrucevap = 1;
                db.dgrucvp = dogrucevap;
            }
            if (rdb_cvpb.Checked)
            {
                dogrucevap = 2;
                db.dgrucvp = dogrucevap;
            }
            if (rdb_cvpc.Checked)
            {
                dogrucevap = 3;
                db.dgrucvp = dogrucevap;
            }
            if (rdb_cvpd.Checked)
            {
                dogrucevap = 4;
                db.dgrucvp = dogrucevap;
            }
            //BURADA RADİOBUTONUN ŞIKKINI VE TEXTBOXDAKİ CEVABI BİRLİKTE ALDIK VE KAYDETTİK
            string cevap = "";
            string snc = "";
            db.siniflar = cb_siniflar.Text;
            //if (rdb_cvpa.Checked)
            //{
            //    snc = "a";
            //    cevap = txt_cvpa.Text;
            //}
            //if (rdb_cvpb.Checked)
            //{
            //    snc = "b";
            //    cevap = txt_cevapb.Text;
            //}
            //if (rdb_cvpc.Checked)
            //{
            //    snc = "c";
            //    cevap = txt_cevapc.Text;
            //}
            //if (rdb_cvpd.Checked)
            //{
            //    snc = "d";
            //    cevap = txt_cevapd.Text;
            //}

            //if (snc == "a")
            //{
            db.ekle(cb_siniflar.Text, cb_dersler.Text, txt_soru.Text, txt_cvpa.Text, txt_cevapb.Text, txt_cevapc.Text, txt_cevapd.Text, dogrucevap);
            //}
            //if (snc == "b")
            //{
            //    db.ekle(cb_siniflar.Text, cb_dersler.Text, txt_soru.Text, cevap, txt_cvpa.Text, txt_cevapc.Text, txt_cevapd.Text, dogrucevap);
            ////}
            //if (snc == "c")
            //{
            //    db.ekle(cb_siniflar.Text, cb_dersler.Text, txt_soru.Text, cevap, txt_cvpa.Text, txt_cevapb.Text, txt_cevapd.Text, dogrucevap);
            //}
            //if (snc == "d")
            //{
            //    db.ekle(cb_siniflar.Text, cb_dersler.Text, txt_soru.Text, cevap, txt_cvpa.Text, txt_cevapb.Text, txt_cevapc.Text, dogrucevap);
            //}
        }

        private void pb_guncelle_Click(object sender, EventArgs e)
        {
            int dogrucevap = 0;
            if (rb_guncvpa.Checked)
            {
                dogrucevap = 1;
                db.dgrucvp = dogrucevap;
            }
            if (rb_guncvpb.Checked)
            {
                dogrucevap = 2;
                db.dgrucvp = dogrucevap;
            }
            if (rb_guncvpc.Checked)
            {
                dogrucevap = 3;
                db.dgrucvp = dogrucevap;
            }
            if (rb_guncvpd.Checked)
            {
                dogrucevap = 4;
                db.dgrucvp = dogrucevap;
            }
            db.siniflar = cb_gunsinif.Text;
            db.guncelle(dataGridView2, txt_gunsoru.Text, cb_gunders.Text, cb_gunsinif.Text, txt_guncvpa.Text, txt_guncvpb.Text, txt_guncvpc.Text, txt_guncvpd.Text, dogrucevap);
        }

        private void pb_gunara_Click(object sender, EventArgs e)
        {
            db.siniflar = cb_gunsnfara.Text;
            db.goster(dataGridView2, cb_gunsnfara.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cb_gunsinif.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            cb_gunders.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txt_gunsoru.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txt_guncvpa.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txt_guncvpb.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txt_guncvpc.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            txt_guncvpd.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            
        }
    }
}
