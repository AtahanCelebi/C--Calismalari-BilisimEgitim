using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personCalisma
{
    internal interface IPerson   //interface'e sadece metodların gövdesi yazılır
    {                              //burası sadece gösterim kısmıdır.
                                      //Burada tanımlanan metodlar classlar altında hepsi tanımlanmalıdır
        personClass Bul(int id);
        void Ekleme(personClass ppl);

        void Silme(int id);

        List<personClass> Listele();
    }
}
