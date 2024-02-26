using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    internal class ListelemeMetotları
    {
        BaglantiAcma ba = new BaglantiAcma();
        public void HastaListele(DataGridView hasta_table)
        {

            string list_query = $"Select * from Hastalar";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query,ba.BaglantiAc());
           //Sorgu sonucu bize bir tablo gelir.
            DataTable randevular_table = new DataTable();//Gelen sql tablo verisini karşılaması için bir DataTable yapısı oluşturdum.
            adapter.Fill(randevular_table); //adapterdan gelen tabloyu fill metodu ile oluşturduğum DataTable nesnesine dolduruyorum
            hasta_table.DataSource = randevular_table;//DataGridView türündeki tablo_randevulara DataSource yardımıyla aktarılıyor.

        }
        public void HastaListele(DataGridView hasta_table,string tc)
        {
            string list_query = $"Select * from Hastalar where HastaTC='{tc}' ";
            SqlDataAdapter adapter = new SqlDataAdapter(list_query, ba.BaglantiAc());//Sorgu sonucu bize bir tablo gelir.
            DataTable randevular_table = new DataTable();//Gelen sql tablo verisini karşılaması için bir DataTable yapısı oluşturdum.
            adapter.Fill(randevular_table); //adapterdan gelen tabloyu fill metodu ile oluşturduğum DataTable nesnesine dolduruyorum
            hasta_table.DataSource = randevular_table;//DataGridView türündeki tablo_randevulara DataSource yardımıyla aktarılıyor.
        }
        public void RandevuListele(DataGridView randevu_table)
        {
         



            string list_query2 = $"Select * from Randevular";
            SqlDataAdapter adapter2 = new SqlDataAdapter(list_query2, ba.BaglantiAc());//Sorgu sonucu bize bir tablo gelir.
            DataTable randevular_table2 = new DataTable();//Gelen sql tablo verisini karşılaması için bir DataTable yapısı oluşturdum.
            adapter2.Fill(randevular_table2); //adapterdan gelen tabloyu fill metodu ile oluşturduğum DataTable nesnesine dolduruyorum
            randevu_table.DataSource = randevular_table2;//DataGridView türündeki tablo_randevulara DataSource yardımıyla aktarılıyor.
        }



    }
}
