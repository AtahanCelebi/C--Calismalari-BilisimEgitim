using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class arabaManager : IFileManager<Araba>
    {
        static DataTable dt = new DataTable();

        public arabaManager()
        {
            dt.Columns.Add("Plaka",typeof(string));
            dt.Columns.Add("Marka No",typeof(int));
            dt.Columns.Add("Model No",typeof(int));
            dt.Columns.Add("Model Yılı",typeof(int));
            dt.Columns.Add("Yakıt", typeof(Yakit));
            dt.Columns.Add("Çekiş Gücü",typeof(Cekis));
        }

        public void Ekle(Araba model)
        {
            DataRow dr = dt.NewRow();
            dr[0] = model.plaka;
            dr[1] = model.markaID;
            dr[2] = model.modelID;
            dr[3] = model.modelYili;
            dr[4] = model.yakitTuru;
            dr[5] = model.cekisGucu;

            dt.Rows.Add(dr);
        }

        public DataTable List()
        {
            return dt;
        }
    }
}
