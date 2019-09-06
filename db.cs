using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Collections;

namespace Sorumatik_Projesi
{
    public class db
    {
        public OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sorumatik.accdb;");
        public OleDbCommand komut = new OleDbCommand();
        public OleDbDataReader oku;
        DataTable tablo = new DataTable();
        DataSet ds = new DataSet();
        OleDbDataAdapter adtr;
        public Random at = new Random();
        public string siniflar = "";
        public string dersler = "",resimders;
        public int resim,dgrucvp;
        public ArrayList cevablar=new ArrayList();
        public bool durum;
        public DataTable tablo1;
        public int adsa;
        public int sym;

        
        
        public int i = -1, gelen = 0;
        public string soru, cvp1, cvp2, cvp3, cvp4;

        public void giris(string id, string sifre)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select *from Yon_Pnl Where Kul_id='" + id + "'and Sifre='" + sifre + "'";
            oku = komut.ExecuteReader();
            if (oku.Read())
            {
                durum = true;
                Yonp_islemler frm = new Yonp_islemler();
                MessageBox.Show("Giriş Başarılı", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.Show();
                
            }
            else
            {
                durum = false;
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Yanlıştır Lütfen Tekrar Deneyiniz.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglanti.Close();
        }
        
        public void ekle(string sinif, string ders, string soru, string cevap1, string cevap2, string cevap3, string cevap4,int dogrucvp)
        {

            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Insert into " + siniflar + "(Sinif,Ders,Soru,Cvp_1,Cvp_2,Cvp_3,Cvp_4,Dogru_cvp) values('" + sinif + "','" + ders + "','" + soru + "','" + cevap1 + "','" + cevap2 + "','" + cevap3 + "','" + cevap4 + "','"+dogrucvp+"')";
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Eklendi", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
        public void sil(DataGridView grid)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            if (grid.SelectedRows.Count > 0)
            {
                komut.CommandText = "UPDATE " + siniflar + " SET Silindi=1 Where id=" +    grid.Rows[grid.SelectedRows[0].Index].Cells[0].Value.ToString() + "";
                komut.ExecuteNonQuery();
                //komut.CommandText = "Delete from " + siniflar + " Where id=" +    grid.Rows[grid.SelectedRows[0].Index].Cells[0].Value.ToString() + "";
                //komut.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
        }

        public void goster(DataGridView grid, string sinif)
        {
            tablo.Clear();
            baglanti.Open();
            adtr = new OleDbDataAdapter("Select * from " + siniflar + " Where Sinif='" + sinif + "' and Silindi=0", baglanti);
            adtr.Fill(tablo);
            grid.DataSource = tablo;
            baglanti.Close();
        }

        public void guncelle(DataGridView grid, string soru, string ders, string sinif, string cvp1,string cvp2,string cvp3,string cvp4,int dogru)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Update " + siniflar + " set Sinif='" + sinif + "',Ders='" + ders + "',Soru='" + soru + "',Cvp_1='" + cvp1 + "',Cvp_2='" + cvp2 + "',Cvp_3='" + cvp3 + "',Cvp_4='" + cvp4 + "',Dogru_cvp="+dogru+" Where id=" + grid.Rows[grid.SelectedRows[0].Index].Cells[0].Value.ToString() + "";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        //BURADA
        public void sorular(ListBox list, RichTextBox txt,Label lbl3, Label lbl1, Label lbl2, RadioButton rdba, RadioButton rdbb, RadioButton rdbc, RadioButton rdbd,PictureBox pas,PictureBox dvm)
        {

            
            OleDbDataAdapter adaptor = new OleDbDataAdapter("Select * From " + siniflar + " Where Ders='" + dersler + "' and Silindi=0 Order By id", baglanti);
            tablo1 = new DataTable();
            adaptor.Fill(tablo1);
            i++;
            if (i < tablo1.Rows.Count)
            {
                lbl2.Text = "Soru "+(i+1)+" -) :";
                gelen = i;
                soru = tablo1.Rows[gelen]["Soru"].ToString();
                cvp1 = tablo1.Rows[gelen]["Cvp_1"].ToString();
                cvp2 = tablo1.Rows[gelen]["Cvp_2"].ToString();
                cvp3 = tablo1.Rows[gelen]["Cvp_3"].ToString();
                cvp4 = tablo1.Rows[gelen]["Cvp_4"].ToString();
            }
            else
            {

                OleDbDataReader oku2 = null;
                baglanti.Open();
                for (i = 1; i < (tablo1.Rows.Count +1 ); i++)
                {
                    OleDbCommand komut2 = new OleDbCommand();
                    komut2.Connection = baglanti;
                    komut2.CommandText ="Select * from " + siniflar + " Where id=" + i + " and Dogru_cvp=" + cevablar[i-1] + "";
                    oku2 = komut2.ExecuteReader();
                    if (oku2.Read())
                    {
                        list.Items.Add(i + " -) Doğru ");
                    }
                    else
                    {
                        list.Items.Add(i + " -) Yanlış ");
                    }
                } 

                baglanti.Close();
                lbl3.Text = resim+". Sınıf "+resimders+" Dersi Cevapları ";
                lbl3.Visible = true;
                list.Visible = true;
                txt.Visible = false;
                lbl1.Visible = false;
                lbl2.Visible = false;
                rdba.Visible = false;
                rdbb.Visible = false;
                rdbc.Visible = false;
                rdbd.Visible = false;
                pas.Visible = false;
                dvm.Visible = false;
            }
        }
        
    }
}

