using System;
using System.Collections;

namespace hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            //HASHTABLE
            //Tanımlama
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(16, "Bursa");
            sehirler.Add(17, "Canakkale");

            //Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,3}-{item.Value,20}");
            }

            //Anahtarları alma
            Console.WriteLine("Anahtarlar (Keys)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Degerleri alma
            Console.WriteLine("Değerler (Values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            //Spesifik elemana erişme
            Console.WriteLine(sehirler[16]);

            //Eleman silme
            sehirler.Remove(16);
            Console.WriteLine();
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,3}-{item.Value,20}");
            }










            Console.ReadKey();
        }
    }
}
