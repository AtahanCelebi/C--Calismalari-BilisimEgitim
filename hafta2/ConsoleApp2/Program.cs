using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] sayilar = new int[8];
            sayilar[0] = 10;
            sayilar[1] = 140;
            sayilar[2] = 1210;
            sayilar[3] = 140;

            ///Her bir fonksiyon için döner.
            foreach(var item in sayilar)
            {
                Console.WriteLine(item);
            }
            ///True false döner
            Console.WriteLine(sayilar.Contains(140));
            ///Max value
           Console.WriteLine(sayilar.Max());


            Console.ReadKey();
        }
    }
}
