using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araclarInterface
{
    internal class motosiklesManager
    {
        List<AracClass> motosikletList = new List<AracClass>();

        public AracClass Bul(int seriNo)
        {
            return motosikletList.FirstOrDefault(car => car.seriNo == seriNo);
        }

        public void Ekle(AracClass arac)
        { 
            var yeniArac = Bul(arac.seriNo);
            if(yeniArac == null)
            {
                motosikletList.Add(arac);
            }
            else
            {
                yeniArac.marka = arac.marka;
                yeniArac.fiyat = arac.fiyat;
                yeniArac.modelYili = arac.modelYili;
            }
        }

        public void Sil(int seriNo)
        {
            motosikletList.Remove(Bul(seriNo));
        }

        public List<AracClass> Listele()
        { 
            return motosikletList;
        }
    }
}
