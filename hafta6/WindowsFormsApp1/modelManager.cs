using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class modelManager : IFileManager<Model>
    {
        static DataTable dt = new DataTable();

        public modelManager()
        {
            dt.Columns.Add("Model No", typeof(int));
            dt.Columns.Add("Model Adı",typeof(string));
            dt.Columns.Add("Marka ID",typeof(int));

        }

        public void Ekle(Model model)
        {
            DataRow dataRow = dt.NewRow();
            dataRow[0] = model.modelNo;
            dataRow[1] = model.modelAdi;
            dataRow[2] = model.markaID;

            dt.Rows.Add(dataRow);
        }

        public DataTable List()
        {
            return dt;
        }
    }
}
