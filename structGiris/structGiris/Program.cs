using System;
using System.Collections;
using System.Collections.Generic;

namespace structGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //struct - kullanma
            //Ogrenci ogr = new Ogrenci();
            //ogr.Numara = 10;
            //ogr.Adi = "Mustafa Burak";
            //ogr.Soyadi = "Kilic";
            //ogr.Cinsiyet = true;

            // Alternatif kullanma
            //var ogr2 = new Ogrenci()
            //{
            //    Numara = 20,
            //    Adi = "Demir",
            //    Soyadi = "Kilic",
            //    Cinsiyet = true
            //};

            //var ogr3 = new Ogrenci(30, "Kamuran", "Kilic", true);
            //var ogr4 = new Ogrenci(40, "Cemal", "Sureya");

            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10,"Mustafa","Kilic",true),
                new Ogrenci(20,"Demir","Kilic",true),
                new Ogrenci(30,"Kamuran","Kilic",true),
                new Ogrenci(40,"Cemal","Sureya")
            };

            //foreach (Ogrenci o in ogrenciListesi)
            //{
            //    Console.WriteLine(o);
            //}
            ogrenciListesi.ForEach(o => Console.WriteLine(o));
           

            //Console.WriteLine($"{ogr.Numara} " +
            //    $"{ogr.Adi} {ogr.Soyadi} " +
            //    $"{ogr.Cinsiyet}");
            //Console.WriteLine($"{ogr2.Numara} " +
            //    $"{ogr2.Adi} {ogr2.Soyadi} " +
            //    $"{ogr2.Cinsiyet}");
            //Console.WriteLine($"{ogr3.Numara} " +
            //    $"{ogr3.Adi} {ogr3.Soyadi} " +
            //    $"{ogr3.Cinsiyet}");
            //Console.WriteLine($"{ogr4.Numara} " +
            //    $"{ogr4.Adi} {ogr4.Soyadi} " +
            //    $"{ogr4.Cinsiyet}");

        }
    }
}
