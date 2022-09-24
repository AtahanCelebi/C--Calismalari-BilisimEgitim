using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personCalisma
{
    internal class ogrenciManager: IPerson
    {
        public int Bul(int id)
        {
            return id;
        }
        public int Ekleme(personClass insan)
        {
            return insan.personId;
        }

        public void Silme(int id)
        {
            Console.WriteLine("silindi");
        }

        public void Listele(List<personClass> liste)
        {
            foreach (var item in liste)
            {
                Console.WriteLine($"PersonId: {item.personId}, Ad Soyad: {item.adi}{item.soyadi}");
            }
        }
    }
}
