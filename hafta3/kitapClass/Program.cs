using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap();
            kitap1.sayfaSayisi = 32;
            kitap1.kitapAdı = "Beyaz Diş";

            Kitap kitap2 = new Kitap()
            {
                sayfaSayisi = 500,
                kitapAdı = "Harry Potter"
            };
        }
    }

    public class Kitap
    {
        public string kitapAdı { get; set; }
        public string yazar { get; set; }
        public int sayfaSayisi { get; set; }

        public string bilgileriGetir { get { return "Bilgiler: " + this.kitapAdı.ToUpper() + " " + this.sayfaSayisi+"Sayfa " +"Yazar: "+this.yazar.ToUpper();} set { } }
    }
}
