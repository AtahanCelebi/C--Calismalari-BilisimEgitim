using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personCalisma
{
    internal class ogrenciManager : IPerson
    {
        List<personClass> studentList = new List<personClass>();

        public personClass Bul(int id)
        {
            return studentList.FirstOrDefault(person => person.personId == id);              //studentList[id];
        }

        public void Ekleme(personClass ppl)
        {
            var ogrenci = Bul(ppl.personId);
            if (ogrenci==null)
            { //yoksa ekle 
                studentList.Add(ppl);

            }
            else //varsa güncelle
            {
                ogrenci.adi = ppl.adi;
                ogrenci.soyadi = ppl.soyadi;
                ogrenci.yas = ppl.yas;
            }
        }

        public List<personClass> Listele()
        {
            return studentList;
        }

        public void Silme(int id)
        {
            studentList.Remove(Bul(id));
            // studentList.RemoveAll(person => person.personId == id);  //yukarıdakiyle aynı işlem
        }
    }
}
