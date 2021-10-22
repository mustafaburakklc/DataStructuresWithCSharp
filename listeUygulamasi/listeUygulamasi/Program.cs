using System;
using System.Collections.Generic;

namespace listeUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            //foreach (string s in sehirler)
            //{
            //    Console.WriteLine(s);
            //}

            // Lambda expression =>
            sehirler.ForEach(s => Console.WriteLine(s));   //list için özel bir gezinme metodu
            Console.WriteLine(new string('-',50));

            var iller = sehirler;  //burda sehirlerin içerikleri illerin içeriklerine yazılmadı, şuan bunlar aynı bellek gözünü gösteriyor.
            iller.ForEach(i => Console.WriteLine(i));
            Console.WriteLine(new string('-', 50));
            
            sehirler.Add("Sinop");    //sinopu sehirlere ekledik. iller ve şehirlere eklendi.
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));
            
            iller.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));

            iller.Remove("Ankara");    //ankarayı illerden kaldırdık. sehirler ve illerden silindi.
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));

            iller.ForEach(s => Console.WriteLine(s));
            Console.WriteLine(new string('-', 50));

            Console.ReadKey();
        }
    }
}
