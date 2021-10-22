using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //DictionaryTemelleri();

            //Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {101,new Personel("Mehmet","Sonsöz",7000) },
                {120,new Personel("Ahmet","Can",9000) }
            };
            personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));

            foreach (var item in personelListesi)
            {
                Console.WriteLine(item);
            }

        }

        private static void DictionaryTemelleri()
        {
            //Dictionary
            //Tanımlama
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"Konya" },
                {424,"Elazığ" },
                {466,"Artvin" },
                {422,"Malatya" }
            };
            //Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");
            //Erişme
            telefonKodlari[466] = "Artvin";
            //ContainKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");

            }
            //ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\nMalatya'nın kod bilgisi tanımlı değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }

            telefonKodlari.Remove(422);
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
        }
    }
}
