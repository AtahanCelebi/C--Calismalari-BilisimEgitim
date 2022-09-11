using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////while-do'da do ilk önce çalışır o yüzden loop+1 dönmeli
            //int sayi=0, sonuc=0;
            //do
            //{
            //    sonuc += sayi;
            //    sayi++;

            //} while (sayi<=10);
            //Console.WriteLine(sonuc);
            //Console.ReadKey();
            //int sayi2 = 0, sonuc2 = 0;

            //while (sayi2<10)
            //{
            //    sayi2++;
            //    sonuc2 += sayi2;
            //}
            //Console.WriteLine(sonuc2);
            //Console.ReadKey();
            ////for döngüsü

            //int sayi3 = 0, sonuc3 = 0;
            //for (int i = 0; i<=10; i++)
            //{
            //    sonuc3 += i;
            //}
            //Console.WriteLine(sonuc3);
            //Console.ReadKey();
            int adet = 0;
            int toplaSay,result=0;
            for (int i = 1; i < 6; i++)
            {   
                Console.Write($"{i}. sayıyı giriniz: "); //   Console.Write("{0}. sayıyı giriniz: ",{0});
                toplaSay = int.Parse(Console.ReadLine());
                result += toplaSay;
                adet++; 

            }
            Console.WriteLine("Sonuç " + result/adet);
            Console.ReadKey();

        }
    }
}
