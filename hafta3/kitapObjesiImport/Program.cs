using kitapClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapObjesiImport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //çözüm gezgini>> ana kapsüle sağ tıkla > Ekle> Başvuru(Reference) 
            // Oradan projelerden üzerine kullanılacak class'a tik at

            Kitap yeniKitap = new Kitap() { 
            sayfaSayisi=300,
            kitapAdı = "kpss Mat",
            yazar = "ahmet"
            };

            

            Console.WriteLine(yeniKitap.bilgileriGetir);
            Console.ReadKey();
        }
    }
}
