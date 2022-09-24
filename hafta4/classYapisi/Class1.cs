using KitapSiparis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classYapisi
{
    internal class Siparis  
    {
        public int adet { get; set; }
        public int siparisId { get; set; }
        public  Kitap kitap { get; set; }

        public DateTime siparisTarihi => DateTime.Now;
    }
}
