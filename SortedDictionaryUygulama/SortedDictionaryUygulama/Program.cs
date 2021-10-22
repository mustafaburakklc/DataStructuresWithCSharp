using System;
using System.Collections.Generic;

namespace SortedDictionaryUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            var kitap = new SortedDictionary<string, List<int>>()
            {
                {"HTML",new List<int>(){8,10,12} },
                {"CSS",new List<int>(){70,80,90} },
                 {"jQuery",new List<int>(){3,5,15} },
                  {"SQL",new List<int>(){70,80} }
            };
            kitap.Add("FTP", new List<int>() { 3, 5, 7 });
            kitap.Add("ASP.NET", new List<int>() { 50, 60 });

            foreach (var kavram in kitap)
            {
                Console.WriteLine(kavram.Key);
                kavram.Value.ForEach(s => Console.WriteLine("\t>"+s));
                //foreach (int s in kavram.Value)
                //{
                //    Console.WriteLine($"\t>{s,-5}");
                //}
            }
        }
    }
}
