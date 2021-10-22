using System;
using System.Collections;

namespace sortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortedList -Temeller

            //Tanımlama
            var list = new SortedList()
            {
                {1,"Bir" },
                {2,"Iki" },
                {3,"Uc" },
                {4,"Dort" },
                {5,"Bes" },
                {6,"Alti" },
                {7,"Yedi" },
                {8,"Sekiz" },
                {9,"Dokuz" },
                {10,"On" },
            };
            
            //Dolaşma
            foreach (DictionaryEntry item in list)
            {
                
                Console.WriteLine($"{item.Key,3}--{item.Value,-10}");
                
            }

            Console.WriteLine();
            Console.WriteLine("Listedeki eleman sayisi:{0} ",list.Count);
            Console.WriteLine("Listenin kapasitesi    :{0} ", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin trimToSize sonrası kapasitesi:{0}",list.Capacity);
            Console.WriteLine();
            //Erişme
            //Key
            Console.WriteLine(list[4]); //key'e bagli deger geliyor.
            //Index
            Console.WriteLine(list.GetByIndex(0));
            //Indisle anahtar alma
            Console.WriteLine(list.GetKey(0));
            //Liste sonundaki elemanın değeri
            Console.WriteLine(list.GetByIndex(list.Count-1));

            var anahtarlar= list.Keys;
            Console.WriteLine("\nANAHTARLAR\n");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }


            var degerler = list.Values;
            Console.WriteLine("\nDEGERLER\n");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nGUNCELLEME");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            Console.WriteLine("Hello World!");
        }
    }
}
