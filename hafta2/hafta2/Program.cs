using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float vize, final, ortalama;
            string sonuc;
            Console.WriteLine("vize notu");
            vize = float.Parse(Console.ReadLine());

            Console.WriteLine("final notu");
            final = float.Parse(Console.ReadLine());

            ortalama = vize * 0.4f + final * 0.6f;

            if (ortalama <= 100 && ortalama > 90)
                sonuc = "A+";
            else if (ortalama > 80 && ortalama < 90)
                sonuc = "A";
            else if (ortalama > 70 && ortalama < 80)
                sonuc = "B+";
            else if (ortalama > 60 && ortalama < 70)
                sonuc = "B";
            else
                sonuc = "kaldıınız";

            Console.WriteLine($"Geçme notunuz: {sonuc}");
            Console.ReadKey();
                    
        }
    }
}
