using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.netEx
{
    internal class Product
    {
        public int productId { get; }
        public string productName { get; set; }

        public int brandId { get; set; }
        public int categoryId { get; set; }
    }
}
