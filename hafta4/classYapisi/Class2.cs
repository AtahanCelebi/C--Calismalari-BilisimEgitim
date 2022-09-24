using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitapSiparis
{
    internal class Kitap
    {
        public decimal fiyat { get; set; }
        public int adet { get; set; }
        public int kitapId { get; set; }
        public string KitapAdı { get; set; }
        public DateTime eklenmeTarihi { get; set; }
    }
}
