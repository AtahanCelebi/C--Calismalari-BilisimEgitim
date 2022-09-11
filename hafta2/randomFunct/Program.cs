using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomFunct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rastgele sayı üret
            Random rnd = new Random();

            //1 ile 49 arasinda random 6 adet sayı üretelim
            int[] sansliSayilar = new int[6];
            int[] kendiSayılarım = new int[6];

            int times = 6; //6kere dönsün

            for (int i = 0; i < times; i++)
            {
                sansliSayilar[i] = rnd.Next(1, 49);
            }

            //6kere input al
            for (int i = 0; i < times; i++)
            {
                Console.Write("Sayı giriniz: ");
                kendiSayılarım[i] = Int32.Parse(Console.ReadLine());

            }
            //Kıyasla

            for (int i = 0; i < times; i++)
            {
                if (kendiSayılarım.Contains(sansliSayilar[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sansliSayilar[i]+" Tutturdunuz");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine(sansliSayilar[i]+" Rakamı için Tekrar Deneyiniz!!!");
                }
            }

            //Konsol yazısının rengini değiştirir!!!

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var sayi in sansliSayilar)
            {
                Console.Write(sayi + " ");
            }

            Console.ReadKey();








            Console.ReadKey();

        }
    }
}
