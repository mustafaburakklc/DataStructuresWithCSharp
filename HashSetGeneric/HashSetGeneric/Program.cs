using System;
using System.Collections;
using System.Collections.Generic;

namespace HashSetGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanımlama
            var sesliHarf = new HashSet<char>()
            {
                'e','ı','i','u','ü','o','ö','b'
            };
            KoleksiyonYazdir(sesliHarf);
            //Ekleme
            sesliHarf.Add('a');
            KoleksiyonYazdir(sesliHarf);

            //Silme
            sesliHarf.Remove('b');
            KoleksiyonYazdir(sesliHarf);

            var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            KoleksiyonYazdir(alfabe);

            //Türkçe'de kullanılan sesli harfler
            //sesliHarf.ExceptWith(alfabe);
            //sesliHarf.UnionWith(alfabe);
            //sesliHarf.IntersectWith(alfabe);
            sesliHarf.SymmetricExceptWith(alfabe);
            KoleksiyonYazdir(sesliHarf);

            
        }
        static void KoleksiyonYazdir(IEnumerable koleksiyon)
        {
            Console.WriteLine();
            int i = 0;
            foreach (char k in koleksiyon)
            {
                Console.Write($"{k,5}");
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Eleman sayisi: {0}",i);
        }
    }
}
