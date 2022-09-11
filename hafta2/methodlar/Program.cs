using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int toplamSayi = Toplam(new int[] {1,2,3,4,5});
            //Console.Write(toplamSayi);
            int factorialNumber = Factorial(5);
            Console.WriteLine(factorialNumber);

            ///--------------------------------------------------------------------\\\
            Console.Write("Bir sayı giriniz: ");
            int getNumber = Int32.Parse(Console.ReadLine());
            int factFunc2 = Factorial2(getNumber);
            Console.WriteLine("diğer fonksiyon "+factFunc2);

            ///--------------------------------------------------------------------\\\
            ///
            Console.Write("Dikdörtgen uzunluğunu giriniz: ");
            int uzunluk = Int32.Parse(Console.ReadLine());
            Console.Write("Dikdörtgen enini giriniz: ");
            int eni = Int32.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Dikdörtgenin Alanı: {alanHesapla(uzunluk,eni)} \nÇevresi: {cevreHesapla(uzunluk,eni)}");

            ///--------------------------------------------------------------------\\\
            ///
            Console.ForegroundColor = ConsoleColor.Yellow;
            ArrayList sayiListesi = new ArrayList();
            sayiListesi.AddRange(new ArrayList() { 1,2,3,4,-5,-22 });
            int[] theResult = adetHesapla(sayiListesi);
            Console.WriteLine("---------------------X---------------------------");
            Console.WriteLine($"Pozitif Sayısı Adedi: {theResult[0]} Negatif Sayı Adedi: {theResult[1]}");


            Console.ReadKey();

        }

        /// fonksiyonun başına static eklersek anca main statik altında çağırabiliriz
        
        static int[] adetHesapla(ArrayList sayilar)
        {
            int pozitif = 0, negatif = 0;
            int[] tamSayiAdedi = new int[2];
            foreach(int sayi in sayilar)
            {
                if (sayi>0) { 

                    pozitif++; 
                }
                else { negatif++; }
            }
            tamSayiAdedi[0] = pozitif;
            tamSayiAdedi[1] = negatif;
            return tamSayiAdedi;
        }
        
        
        static int alanHesapla(int x, int y)
        {
            return x * y;
        }

        static int cevreHesapla(int x, int y)
        {
            return (x + y) * 2;
        }
        
        
        static  int Toplam(int[] sayilar)
        {
            int sonuc = 0;
            foreach(var sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }

        static int Factorial(int x)
        {
            if (x==1)
                return 1;
            else
            {
                return x*Factorial(x-1);
            }

        }

        static int Factorial2(int x)
        {
            int sonuc = 1;
            for (int i = 1; i < x+1; i++) 
            {
                sonuc *= i;
            }
            return sonuc;
        }

    }
}
