using System;
using System.Collections;

namespace hashtableUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //hashTable uygulamasi
            //basligi okuma
            Console.WriteLine("Baslik giriniz: ");
            string baslik = Console.ReadLine();
            //kucultme
            baslik = baslik.ToLower();

            //hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c' },
                {'ı','i' },
                {'ö','o' },
                {'ü','u' },
                {' ','-' },
                {'\'','-' },
                {'ğ','g' },
                {'.','-' },
                {'?','-' },
                {'ş','s' },
            };

            
            Console.WriteLine(baslik);

        }
    }
}
