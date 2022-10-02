using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_ENUM
{
    internal interface IListe<T> where T : class
    {
        void Ekle(T model);

        List<T> Liste();
    }
}
