using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    internal class Program
    {
        static void yaz(List<Ogrenci> ogrenciler)
        {
            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Yas);
                Console.WriteLine(item.bilgiler);
            }
        }



        static void Main(string[] args)
        {
            Ogrenci ogr = new Ogrenci(); //ilk obje
            ogr.Ad = "ata";
            ogr.Soyad = "ç.";           //obje özellikleri
            ogr.Yas = 24;

            Ogrenci ogr2 = new Ogrenci()  //farklı bir nesne ekleme 
            {
                Ad = "ali",
                Soyad = "v.",
                Yas = 25  //Yas 18 ve altı olursa error vericek!!!
            };

            List<Ogrenci> list = new List<Ogrenci>();
            list.Add(ogr);
            list.Add(ogr2);

            yaz(list);



            Console.ReadKey();
        }

        /*
         Nesne Erişim Belirteçleri
        private > sadece bulunduğu class içerisinden erişilebilir (field, method default olarak private'tır aksini belirtmediğimiz taktirde)
        internal >> bulunduğu namespace içerisinden erişilebilir (classlar default olarak internal'dir)
        public >>> solution içerisinden erişilebilir
         */

        public class Ogrenci
        {
            private int classYas; //sadece class içerisnde olur dışarı çıkartılamaz
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get { return classYas; } set {
                    if (value > 18)            //buradaki value nesneyi kapsayan o anki değer 
                        classYas = value;    //mesela ata için 24'ü, ali için 25'i alır
                    else
                        throw new Exception("yas 18'den küçük olamaz");
                        } }
            public string bilgiler { get { return "Adı: "+this.Ad+" "+"Soyadı: "+this.Soyad+" "+"Yaşı: "+this.Yas; } set { } }

        }
    }
}
