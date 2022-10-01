using ClassKavramlar.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramlar.Managers
{
    internal interface IManager<W> where W : class
    {
        void Add(W model);
        bool Remove(int Id);
        W Get(int Id);
        List<W> GetAll();
    }
}
