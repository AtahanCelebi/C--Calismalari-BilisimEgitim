
using ClassKavramlar.Sınıflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassKavramlar.Managers
{
    internal class CategoryManager : IManager<category>
    {
         static List<category>   categories= new List<category>(); // categoriler tutmak için
        public void Add(category model)
        {
            // sorgulayacağız
            if(Get(model.catId)!=null)  // boş değilse update
            {
                // update
                category degisecekCategory = Get(model.catId);
                degisecekCategory.catName = model.catName;
                degisecekCategory.catImage = model.catImage;

            }
            else
            {  //add
                categories.Add(model);
            }
            
        }

        public category Get(int Id)
        {
            return categories.FirstOrDefault(x => x.catId == Id);
        }

        public List<category> GetAll()
        {
            return categories;
        }
        public bool Remove(int Id)
        {
             return categories.Remove(Get(Id));            
        }
        public static  List<category> GetAllCategory()
        {
            return categories;
        }
    }
}
