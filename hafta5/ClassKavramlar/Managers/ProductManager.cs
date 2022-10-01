using ClassKavramlar.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramlar.Managers
{
    internal class ProductManager : IManager<product>
    {
        List<product> products= new List<product>();
        public void Add(product model)
        {
            if (products.Contains(model))
            {
                product degisecekProduct = Get(model.productId);
                degisecekProduct.productName = model.productName;
                degisecekProduct.productImage = model.productImage;
                degisecekProduct.stockQuantity = model.stockQuantity;
                degisecekProduct.Price=model.Price;
                degisecekProduct.categoryId=model.categoryId;
            }
            else
            {
                products.Add(model);
            }
        }

        public product Get(int Id)
        {
            return products.FirstOrDefault(x=>x.productId==Id);
        }

        public List<product> GetAll()
        {
            return products;
        }

        public bool Remove(int Id)
        {
            return products.Remove(Get(Id));
        }
    }
}
