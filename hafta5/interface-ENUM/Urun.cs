using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ENUM
{
    #region Ürün Class
    internal class Urun
    {
        public Guid urunKod { get; set; }
        public string urunAdi { get; set; }
        public decimal fiyat { get; set; }
        public UrunDurumu durum { get; set; }
    }
    #endregion

    internal class Sepet
    {
        public int sepetId { get; set; }

        public  Urun urun { get; set; }

        public int adet { get; set; }

    }



    internal class Siparis
    {
        public int siparisKodu { get; set; }
        public List<Urun> urun { get; set; }
        public DateTime siparisTarihi => DateTime.Now;

        public SiparisDurumu durum { get; set; }
    }

    internal class SiparisListManager : IListe<Siparis>
    {
        static List<Siparis> siparisListesi = new List<Siparis>();
        public void Ekle(Siparis model)
        {
            if (siparisListesi.Exists(u => u.siparisKodu == model.siparisKodu))
            {
                var bulunanSiparis = siparisListesi.Find(y => y.siparisKodu == model.siparisKodu);
                bulunanSiparis.durum = model.durum;
            }
            else
            {
                siparisListesi.Add(model);
            }
        }


        public List<Siparis> Liste()
        {
            return siparisListesi;
        }
    }

    internal class UrunListManager: IListe<Urun>
    {
        static List<Urun> urunListesi = new List<Urun>();

        public void Ekle(Urun model)
        {
            if (urunListesi.Exists(u => u.urunKod == model.urunKod))
            {
                var bulunanUrun= urunListesi.Find(y => y.urunKod == model.urunKod);
                bulunanUrun.urunAdi = model.urunAdi;
                bulunanUrun.fiyat = model.fiyat;
                bulunanUrun.durum = model.durum;
            }
            else
            {
                urunListesi.Add(model);
            }
        }


        public List<Urun> Liste()
        {
            return urunListesi;
        }


        public List<Sepet> sepetListesi = new List<Sepet>();

        void sepeteEkle(Urun urun, int adet)
        {
            int yeniSepetId = sepetListesi.Count > 0 ? sepetListesi.Max(x => x.sepetId) : 0;

            if (yeniSepetId > 0)
            {
                yeniSepetId++;
            }
            else
            {
                yeniSepetId = 1;
            }

            Sepet yeniSepet = new Sepet()
            {
                sepetId = sepetteVarMi(urun) ? sepetListesi.FirstOrDefault(x => x.urun.urunKod== urun.urunKod).sepetId: yeniSepetId,
                urun = urun,
                adet = adet
            };

            sepetListesi.Add(yeniSepet);

        }


         bool sepetteVarMi(Urun urunSorgu)
        {  //sepetin içindeki ürün kodu daha önce mevcutsa onu bulmalı
            return sepetListesi.Exists(x => x.urun.urunKod == urunSorgu.urunKod); 
        }


        void sepetiTemizle()
        {
            sepetListesi.Clear();
        }






    }


}
