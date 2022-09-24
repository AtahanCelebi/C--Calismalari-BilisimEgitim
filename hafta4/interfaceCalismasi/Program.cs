using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceCalismasi
{
    internal class Shape
    {
        public double x { get; set; }
        public double y { get; set; }
    }

    class Rectangle : Shape
    {

    }

    class Square: Shape
    {

    }

    class Triangle : Shape
    {
        public double z { get; set; }
    }

    internal class Program { 
    static void Main(string[] args)
    {
            Console.WriteLine("1-üçgen");
            Console.WriteLine("2-dikdörtgen");
            Console.WriteLine("3-kare");
            Console.WriteLine("seçim");
            int secim = Int32.Parse(Console.ReadLine());

            triangleOperation triangle = new triangleOperation();
            rectangleOperation rectangle = new rectangleOperation();   
            squareOperation square = new squareOperation();

            double x, y, z;
            switch (secim)
            {
                case 1:
                    {
                        Console.Write("x degeri:");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("y degeri:");
                        y = double.Parse(Console.ReadLine());
                        Console.Write("z degeri:");
                        z = double.Parse(Console.ReadLine());

                        Console.WriteLine("Üçgenin alanı:{0}",triangle.Alan(new Triangle() { x = x, y = y, z = z }));  //ilki class değeri x=x
                        Console.WriteLine("Üçgenin çevresi:{0}",triangle.Cevre(new Triangle() { x = x, y = y, z = z })); //ikincisi buradaki tanımlı x

                        break;
                    }
                case 2:
                    {
                        Console.Write("x degeri:");
                        x = double.Parse(Console.ReadLine());
                        Console.Write("y degeri:");
                        y = double.Parse(Console.ReadLine());

                        Console.WriteLine("Dikdörtgenin Alanı {0}", rectangle.Alan(new Rectangle() { x = x, y = y })); //ilki class değeri
                        Console.WriteLine("Dikdörtgenin Çevresi {0}", rectangle.Cevre(new Rectangle() { x = x, y = y })); //ikincisi buradaki tanımlı


                        break;
                    }
                case 3:
                    {
                        Console.Write("x degeri:");
                        x = double.Parse(Console.ReadLine());

                        Console.WriteLine("Karenin Alanı {0}", square.Alan(new Square() { x=x}));
                        Console.WriteLine("Karenin Çevresi {0}", square.Cevre(new Square() { x=x}));

                        break;
                    }
                default:
                    break;
            }
            Console.ReadKey();

        }

    }
}
