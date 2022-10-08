using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class markaManager : IFileManager<Marka>
    {
        //static List<Marka> markaList = new List<Marka>();
        static DataTable dt = new DataTable();
        public markaManager() //constructur fonksiyonu, yapıcı method
        {
            dt.Columns.Add("Marka no", typeof(int));
            dt.Columns.Add("Marka adi", typeof(string));
        }
        public void Ekle(Marka model)
        {
           
            DataRow dr = dt.NewRow();
            dr[0] = model.markaNo;
            dr[1] = model.markaAdi;
            dt.Rows.Add(dr);
        }

        public DataTable List()
        {
            return dt;
        }
    }
}
