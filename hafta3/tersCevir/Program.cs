using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tersCevir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = tersCevir("ali");
            Console.WriteLine(x);

            Console.Write("metin giriniz: ");
            string metin = Console.ReadLine();
            Console.WriteLine(tersCevir(metin));
            Console.ReadKey();


        }
        static string tersCevir(string myStr)
        {
            string result = "";
            int strLength = myStr.Length;
            for(int i = strLength-1; i >= 0; i--)
            {
                result += myStr[i];
            }

            return result;
        }
    }
}
