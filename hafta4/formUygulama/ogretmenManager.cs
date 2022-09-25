using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personCalisma
{
    internal class ogretmenManager: IPerson
    {
        List <personClass> ogretmenListesi = new List<personClass> ();

        public personClass Bul(int id)
        {
            return ogretmenListesi.FirstOrDefault(ppl => ppl.personId == id);
        }
        public void Ekleme(personClass ppl)
        {
            var ogretmen = Bul(ppl.personId);
            if (ogretmen == null)
            { //yoksa ekle 
                ogretmenListesi.Add(ppl);

            }
            else //varsa güncelle
            {
                ogretmen.adi = ppl.adi;
                ogretmen.soyadi = ppl.soyadi;
                ogretmen.yas = ppl.yas;
            }
        }

        public void Silme(int id)
        {
            ogretmenListesi.Remove(Bul(id));
            //ogretmenListesi.RemoveAll(ppl => ppl.personId == id);   //alternatif 
        }

        public List<personClass> Listele()
        {
            return ogretmenListesi;
        }
    }
}
