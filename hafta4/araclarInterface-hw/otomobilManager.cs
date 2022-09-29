using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araclarInterface
{
    internal class otomobilManager
    {
        List<AracClass> otomobilList = new List<AracClass>();
        public AracClass Bul(int seriNo)
        {
            return otomobilList.FirstOrDefault(deger => deger.seriNo == seriNo);
        }
        public void Ekle(AracClass arac)
        {
            var yeniArac = Bul(arac.seriNo);
            if(yeniArac == null)
            {
                otomobilList.Add(arac);
            }
            else
            {
                yeniArac.marka = arac.marka;
                yeniArac.modelYili = arac.modelYili;
                yeniArac.fiyat = arac.fiyat; ;
            }
        } 

        public void Sil(int seriNo)
        {
            //otomobilList.Remove(Bul(seriNo));
            otomobilList.RemoveAll(silinecekArac => silinecekArac.seriNo == seriNo);
        }

        public List<AracClass> Listele()
        {
            return otomobilList;
        } 
    }
}
