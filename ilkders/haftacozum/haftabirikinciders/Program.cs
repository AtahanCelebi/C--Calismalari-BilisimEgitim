using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haftabirikinciders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sicaklik;
            Console.Write("Sıcaklık değeri giriniz:");
            sicaklik = Convert.ToDecimal(Console.ReadLine());
            if (sicaklik >= 0 && sicaklik < 30)
            {
                Console.WriteLine("sıcak");
            }
            else if (sicaklik >= 30 && sicaklik <= 60)
            {
                Console.WriteLine("çok sıcak");
            }
            else 
            {
                Console.WriteLine("aşırı sıcak");
            }
            Console.ReadKey();
        }
    }
}
