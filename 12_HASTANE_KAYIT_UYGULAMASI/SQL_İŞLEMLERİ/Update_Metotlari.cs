using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    //ExecuteNoneQuery en = new ExecuteNoneQuery();
    //BaglantiAcma ba = new BaglantiAcma();
    internal class Update_Metotlari
    {
        ExecuteNoneQuery en = new ExecuteNoneQuery();
        BaglantiAcma ba = new BaglantiAcma();

        public void Update(string sikayet,int randevuid)
        {

            string guncelle = $"Update Randevular set HastaSikayet='{sikayet}' where RandevuID='{randevuid}'";

            
            en.Execute(guncelle, ba.BaglantiAc());
            ba.BaglantiKapat(ba.BaglantiAc());


        }
    }
}
