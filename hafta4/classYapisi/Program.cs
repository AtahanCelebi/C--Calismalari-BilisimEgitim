using KitapSiparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classYapisi
/*
 * constructor hep classda yapıcı olarak bulunur, tanımlamasak bile
 sealed class > kalıtım yapılamamasını istiyorsak
abstract class > soyutlamak için kullanılır
 */
{
    internal class Program
    {
        static List<Kitap> kitaplik = new List<Kitap>(); // fonksiyonda static olduğu için başına static yazılmalı!
        static List<Siparis> siparisler = new List<Siparis>();


        static void SiparisListesi()
        {
            foreach(Siparis item in siparisler)
            {
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine($"Kitap Adı:{item.kitap.KitapAdı} Siparis Id: {item.siparisId} Kitap Fiyat: {item.kitap.fiyat} Siparis Tutar: {item.adet*item.kitap.fiyat}");
                Console.WriteLine("----------------------------------------------------------------------------------------");

            }
        }

        static void YeniSiparis()
        {
            KitapListesi();
            Console.WriteLine("satın alınacak kitap id'si: ");
            int siparisKitapId = Int32.Parse(Console.ReadLine());

            var gelenKitap = kitaplik.FirstOrDefault(item => item.kitapId==siparisKitapId); //kitaplık içinde arama yap

            if (gelenKitap != null)
            {
                Console.WriteLine("kaç adet sipariş edeceksiniz: ");
                int siparisAdeti = Int32.Parse(Console.ReadLine());


                if (gelenKitap.adet >= siparisAdeti)  // listesindeki kitap adeti , girilen adetten fazla mı?
                {
                    Siparis spr = new Siparis()
                    {
                        siparisId = new Random().Next(1, 1000), //1'den 1000'e kadar random bir sayı 
                        kitap = gelenKitap,
                        adet = siparisAdeti
                    };
                    siparisler.Add(spr);
                    gelenKitap.adet -= siparisAdeti;  //gelen siparişten stok adetini düş
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    Console.WriteLine($"Kitap Adı: {gelenKitap.KitapAdı} Kalan Adet: {gelenKitap.adet} adet Sipariş Edilen Miktar: {siparisAdeti} Ücret: {gelenKitap.fiyat*siparisAdeti}TL");
                    Console.WriteLine("-------------------------------------------------------------------------------");

                }
                else
                {

                    Console.WriteLine("---------------");
                    Console.WriteLine("Stok Yetersiz!!!");
                    Console.WriteLine("---------------");

                }

            }
            else
            {
                Console.WriteLine("kitap bulunamadı");
            }

        }

        static void KitapListesi()
        {
            foreach(var kitap in kitaplik)
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"Kitap Adı: {kitap.KitapAdı}\tKitap Id: {kitap.kitapId}\tKitabın Fiyatı: {kitap.fiyat}\tKitap Adeti: {kitap.adet} adet");
                Console.WriteLine("-----------------------------------------------------------------------------");

            }
        }

        static void KitapGirisi()
        {
            Console.WriteLine("kitap no gir");
            int kitapId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("kitap ismi gir");
            string kitapAdı = Console.ReadLine();
            Console.WriteLine("fiyat");
            decimal fiyat = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("adet gir");
            int adet = Int32.Parse(Console.ReadLine());

            Kitap ktp = new Kitap()
            {
                adet = adet,              //ilk Kitap class içerisindeki sonraki değer KitapGirisi() fonksiyon içerisindeki
                fiyat = fiyat,            // değere aittir.
                KitapAdı = kitapAdı,
                kitapId = kitapId,
                eklenmeTarihi = DateTime.Now
            };

            kitaplik.Add(ktp);
            

        }

        static void Main(string[] args)
        {  
            bool exit = false;
            string secim;
            do
            {
                Console.WriteLine("1-kitap girişi");
                Console.WriteLine("2-kitap listesi");
                Console.WriteLine("3-yeni sipariş girişi");
                Console.WriteLine("4-sipariş listesi");
                Console.WriteLine("q-çıkış");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1": 
                        {
                            KitapGirisi();
                            break;
                        }
                    case "2": 
                        {
                            KitapListesi();

                            break;

                        }
                    case "3": 
                        {
                            YeniSiparis();
                            break;

                        }
                    case "4": 
                        {
                            SiparisListesi();
                            break;

                        }

                    case "q":
                    case "Q":
                        {
                            exit = true;
                            break;
                        }


                    default:

                        break;
                }



            } while (!exit);
        }
    }
}
