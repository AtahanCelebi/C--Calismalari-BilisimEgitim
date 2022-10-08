using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface IFileManager<T>
    {
        void Ekle(T model);

        DataTable List();
    }
}
