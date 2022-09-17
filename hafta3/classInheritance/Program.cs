using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classInheritance
{
    internal class Program

        
    {

        static List<string> kitaplık = new List<string>();

        static void KitapKayit()
        {
            Console.WriteLine("kitapid:");
            int kitapID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("kitap fiyat:");
                int kitapFiyat = Int32.Parse(Console.ReadLine());
            Console.WriteLine("kitap ad:");
            string kitapAd = Console.ReadLine();
            kitapClass ktp = new kitapClass()
            {
                kitapAd = kitapAd,
                kitapFiyat = kitapFiyat,
                kitapId = kitapID
            };

            kitaplık.Add(ktp);
        }
        static void Main(string[] args)
        {
            bool exit = false;
            string secim;
            do
            {
                Console.WriteLine("1-kitap kayıt");
                Console.WriteLine("2-kitap sipariş");
                Console.WriteLine("3-kitap listesi");
                Console.WriteLine("q-çıkış");
                Console.Write("Seçiminiz: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        {
                            KitapKayit();
                            break;
                        }
                    case "2":
                        {
                            break;
                        }
                    default:
                        break;
                }




            } while (!exit);
        }
    }
}

