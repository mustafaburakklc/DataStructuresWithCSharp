using System;
using System.Collections.Generic;

namespace classGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tanıma + Atama
            var liste1 = new List<OgretimElemani>()
            {
                  new OgretimElemani(100,"Mustafa","Kilic",true),
                  new OgretimElemani(101,"Aylin","Dag",false),
                  new OgretimElemani(102,"Mehmet","Yilmaz",true),
                  new OgretimElemani(103,"Servet","Aydogdu",true),
                  new OgretimElemani(104,"Leyla","Aydin",false),
                  new OgretimElemani(105,"Selim","Asilhan",true),

            };
            Console.WriteLine("Liste 1");

            liste1.ForEach(ogrGor => Console.WriteLine(ogrGor));
            Console.WriteLine();

            var liste2 = liste1;
            Console.WriteLine("Liste 2");
            liste2.ForEach(ogrGor => Console.WriteLine(ogrGor));

            liste1.RemoveAt(0);
            liste2.Add(new OgretimElemani(106, "Öner", "Ham", true));
            Console.WriteLine("Ekleme yapıldı.");

            liste1.ForEach(ogrGor => Console.WriteLine(ogrGor));
            Console.WriteLine();
            liste2.ForEach(ogrGor => Console.WriteLine(ogrGor));

            
//gördüğümüz gibi class yapısı referans tabanlı olduğu için birbirine atama yapılmış iki class örneği bellekte aynı alanı gösterir.

        }
    }
}
