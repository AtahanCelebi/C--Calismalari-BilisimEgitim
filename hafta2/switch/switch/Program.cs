using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("KK");
            Console.WriteLine("NK");
            Console.WriteLine("HV");
            Console.WriteLine("SEÇİM YAPINIZ");
            string secim = Console.ReadLine().ToLower();

            switch (secim)
            {
                case "kk":
                    {
                        Console.WriteLine("kredi kartı");
                        break;
                    }
                case "nk":
                    {
                        Console.WriteLine("NAKİT");
                        break;
                    }
                case "hv":
                    {
                        Console.WriteLine("Havale");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("seçim yapılmadı");
                        break;
                    }
            }
            Console.ReadKey(); 
            */

           
            bool exit=false;
            do
            {
                Console.WriteLine("hangi mevism: kış,yaz,ilkbahar,sonbahar");
                string secim2 = Console.ReadLine();

                switch (secim2.ToLower())
                {
                    case "ilkbahar":
                        {
                            Console.WriteLine("mart nisan mayıs");
                            break;
                        }
                    case "yaz":
                        {
                            Console.WriteLine("haziran temmuz ağustos");
                            break;
                        }
                    case "kış":
                        {
                            Console.WriteLine("aralık ocak şubat");
                            break;
                        }
                    case "sonbahar":
                        {
                            Console.WriteLine("eylül ekim kasım");
                            break;
                        }
                    case "q":
                        {
                            Console.WriteLine("ÇIKIŞ YAPILIYOR");
                                exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("geçersiz işlem");
                            break;
                        }

                }
            } while (!exit); //exit değeri true değilse dön yani exit==false
            Console.ReadKey();

        }
    }
}
