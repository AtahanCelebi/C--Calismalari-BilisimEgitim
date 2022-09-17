using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolenleriBul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList x = bolenleriBul(32);
            //Console.WriteLine(x);


            Console.Write("super sayımı: ");
            int sayi = Int32.Parse(Console.ReadLine());
            Console.Write(superSayimi(sayi));
            //superSayimi(28) ? Console.WriteLine(sayi + " super sayidir") : Console.WriteLine(sayi + " super sayi değildir");


            Console.ReadKey();
        }
        static ArrayList bolenleriBul(int myNum)
        {
            ArrayList bolenler = new ArrayList();

            for(int i = 1; i < myNum; i++)
            {
                if (myNum % i == 0)
                {
                    Console.WriteLine(i + " ile bölünüyor");
                    bolenler.Add(i);
                }
            }

            return bolenler;

        }

        static bool superSayimi(int isSuper)
        {
            ArrayList bolenlerim = bolenleriBul(isSuper);
            int toplam = 0;
            foreach(int item in bolenlerim)
            {
                toplam += item;
            }

            return toplam == isSuper;

        }
    }
}
