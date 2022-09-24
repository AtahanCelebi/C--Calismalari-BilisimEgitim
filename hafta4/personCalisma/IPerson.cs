using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personCalisma
{
    internal interface IPerson
    {

        string Bul(int id);
        string Ekleme(personClass insan);

        void Silme(int id);

        string Listele(List<personClass> list);
    }
}
