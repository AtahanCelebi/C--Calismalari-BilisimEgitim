using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netEx
{
    internal interface IManager<T>
    {
        void Add(T obj);
        DataTable GetAll();

        void Delete(int id);
    }
}
