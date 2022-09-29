using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace araclarInterface
{
    internal interface IArac //classlarda kullanılacak
                             //metodları tanımlanır
    {
        AracClass Bul(int seriNo); //class içerisinden dönecek 

        void Ekle(AracClass arac);  //classa eklenecek

        void Sil(int seriNo); //bir şey dönmeyecek sadece silecek (void)

        List<AracClass> Listele(); //tüm classlar liste şeklinde dönsün 

    }
}
