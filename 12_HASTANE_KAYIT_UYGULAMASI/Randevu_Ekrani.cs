using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    public partial class Randevu_Ekrani : Form
    {
       
        ListelemeMetotları lm = new ListelemeMetotları();
        Insert_Metotlari im = new Insert_Metotlari();
        Update_Metotlari um = new Update_Metotlari();
       


       
        public Randevu_Ekrani()
        {
            InitializeComponent();
            
        }

        private void Randevu_Ekrani_Load(object sender, EventArgs e)
        {
          

            //HASTALARI EKRANA GETRİRME
            lm.HastaListele(tablo_hastalar);



            //RANDEVULARI EKRANA GETİRME
            lm.RandevuListele(tbl_randevular);
          

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_randevu_olustur_Click(object sender, EventArgs e)
        {
            string tc = txt_randevu_TC.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string klinik = cmb_klinik.Text;
            string sehir = cmb_sehir.Text;
            string doktor = cmb_doktor.Text;
            DateTime randevutarihi = dt_randevu_tarihi.Value;
            string sikayet = txt_sikayet.Text;

            im.RandevuEkle(isim,soyisim,klinik,sehir,doktor,randevutarihi,sikayet,tc);


          
            




        }

        private void btn_hasta_ara_Click(object sender, EventArgs e)
        {

            string tc = txt_hasta_ara_tc.Text;
         



            lm.HastaListele(tablo_hastalar,tc);

        }

       

        private void tablo_randevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e ifadesi datagridviewda tıklanılan satır ve sütun bilgisini alır.
            if (e.RowIndex >= 0)//tıklanılan satır ifadesi 0 dan başladığı için burada tıklanılan satırın 0 olup olmadığı kontrol ettirlir.
            {
                DataGridViewRow row = tablo_hastalar.Rows[e.RowIndex];//e üzerinden gelen satır indeks bilgisi datagridview türündeki tabloda Rows özelliğinde indeks numarası olarak verilir.Buna karşılık gelen veri DataGrdiViewRow türünde bir değişkende tutulur.
                string TC = row.Cells["HastaTC"].Value.ToString(); //gelen satır bilgisi üzerinden satırın hücrelerinde almak istediğim başlıklar nelerse bunları yazıp değişkene aktarıyorum.
                string isim= row.Cells["HastaAd"].Value.ToString();
                string soyisim= row.Cells["HastaSoyad"].Value.ToString();
                string id = row.Cells["HastaID"].Value.ToString();

                txt_randevu_TC.Text = TC;
                txt_isim.Text = isim;
                txt_soyisim.Text = soyisim;
                txt_ID.Text = id;

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            
            int randevuid= Convert.ToInt32(txt_randevuID.Text);
            string tc = txt_randevu_TC.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string klinik = cmb_klinik.Text;
            string sehir = cmb_sehir.Text;
            string doktor = cmb_doktor.Text;
            DateTime randevutarihi = dt_randevu_tarihi.Value;
            string sikayet = txt_sikayet.Text;

            um.Update(sikayet,randevuid);

        }

        private void tbl_randevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e ifadesi datagridviewda tıklanılan satır ve sütun bilgisini alır.
            if (e.RowIndex >= 0)//tıklanılan satır ifadesi 0 dan başladığı için burada tıklanılan satırın 0 olup olmadığı kontrol ettirlir.
            {
                DataGridViewRow row = tbl_randevular.Rows[e.RowIndex];//e üzerinden gelen satır indeks bilgisi datagridview türündeki tabloda Rows özelliğinde indeks numarası olarak verilir.Buna karşılık gelen veri DataGrdiViewRow türünde bir değişkende tutulur.
                string TC = row.Cells["HastaTC"].Value.ToString(); //gelen satır bilgisi üzerinden satırın hücrelerinde almak istediğim başlıklar nelerse bunları yazıp değişkene aktarıyorum.
                string sikayet = row.Cells["HastaSikayet"].Value.ToString();
                string klinik = row.Cells["Klinik"].Value.ToString();
                string doktor = row.Cells["Doktor"].Value.ToString();
                string sehir = row.Cells["Sehir"].Value.ToString();
                string randevuid= row.Cells["RandevuID"].Value.ToString();
                cmb_doktor.Text= doktor;
                cmb_klinik.Text = klinik;
                cmb_sehir.Text = sehir;
                txt_randevuID.Text = randevuid;

                txt_sikayet.Text = sikayet;

            }
        }

        private void btn_tumhastalar_Click(object sender, EventArgs e)
        {
            lm.HastaListele(tablo_hastalar);
           
        }
    }
}
