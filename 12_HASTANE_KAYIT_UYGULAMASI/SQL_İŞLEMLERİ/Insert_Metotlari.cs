using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    internal class Insert_Metotlari
    {
        ExecuteNoneQuery en = new ExecuteNoneQuery();
        BaglantiAcma ba = new BaglantiAcma();
        public void RandevuEkle(string isim,string soyisim,string klinik,string sehir,string doktor,DateTime randevutarihi,string sikayet,string tc)
        {
            string insert_query = $"insert into Randevular (HastaAdi,HastaSoyadi,Klinik,Sehir,Doktor,RandevuTarihi,HastaSikayet,HastaTC)values('{isim}','{soyisim}','{klinik}','{sehir}','{doktor}','{randevutarihi}','{sikayet}','{tc}')";


            en.Execute(insert_query,ba.BaglantiAc());

            ba.BaglantiKapat(ba.BaglantiAc());

        }
    }
}
