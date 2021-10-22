using System;
using System.Collections.Generic;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //sortedSetGiris();
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5, 25));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            //Listedeki benzersiz elemanları bulmak.
            var benzersizSayiListesi = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi\n");
            foreach (var item in benzersizSayiListesi)
            {
                Console.WriteLine($"{item,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("Bensersiz {0} sayi var.",benzersizSayiListesi.Count);
        }

       
        
        
        private static void sortedSetGiris()
        {
            //tanımlama
            var list = new SortedSet<string>();

            //ekleme
            if (list.Add("Mehmet"))   //true veya false döndürür.
            {
                Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                Console.WriteLine("Mehmet eklenemedi.");
            }
            Console.WriteLine("{0}", list.Add("Ahmet") ==
                true ? "Ahmet Eklendi" : "Ekleme Başarısız");

            //add metodu dönüşünün bool olması
            if (list.Add("Mehmet"))   //true veya false döndürür.
            {
                Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                Console.WriteLine("Mehmet eklenemedi.");
            }

            //eleman ekleme
            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            //eleman silme
            list.Remove("Sule"); //Sule'yi sil.
            Console.WriteLine("Sule silindi.");
            list.RemoveWhere(deger => deger.Contains("A"));  //Büyük A içeren elemanları sil.
            list.RemoveWhere(deger => deger.StartsWith("F")); //F ile başlayan elemanları sil.

            Console.WriteLine("\nIsimler Listesi\n");
            //dolaşma
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
            //eleman sayısı
            Console.WriteLine("Eleman sayisi    :{0,3}", list.Count);
        }
    }
}
