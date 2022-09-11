using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylist ile dinamik liste oluşumu
            ArrayList gidalar = new ArrayList();
            gidalar.Add("domates");

            string[] etUrunleri = new string[] { "tavuk", "balık" };
            gidalar.AddRange(etUrunleri);
            gidalar.AddRange(new String[] {"nane","roka","maydonoz"});
            gidalar.AddRange(new ArrayList() {"soğan","enginar"});

            //gidalar.Sort(); //listeyi sıralar
            // gidalar.Clear() // listeyi temizler

            gidalar.Insert(0, "sarımsak"); //belirlenen indexe value ekler

            //gidalar.RemoveAt(5); //5. indexdeki value'yu siler

            foreach(var gida in gidalar)
            {
                Console.WriteLine(gida);
            }
            Console.ReadKey();

        }
    }
}
