using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal struct Araba //Struct class'ın basit ve kısıtlı halidir,
        //belleğin stack bölgesinde saklanır.
        //Classların değeri Heap kısmında saklanır.

        //struclar sadece interface'den miras alabilirler, başka bir class ya da structan miras alamazlar
    {
        public int modelYili { get; set; }
        public string plaka { get; set; }
        public int markaID { get; set; }
        public int modelID { get; set; } //araba model'e refer ediyor, model Marka'ya refer ediyor. Böylelikle
                                         //Araba içinde Marka'yı tanımlamamız gerekmiyor
        public Cekis cekisGucu { get; set; }
        public Yakit yakitTuru { get; set; }

        public string arabaAdi { get; set; }
    }

    internal struct Marka
    {
        public int markaNo { get; set; }

        public string markaAdi { get; set; }
    }

    internal struct Model
    {
        public int modelNo { get; set; }
        public int markaID { get; set; }
        public string modelAdi { get; set; }
    }

  
}
