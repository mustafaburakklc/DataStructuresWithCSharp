using System;
using System.Collections.Generic;

namespace SortedSetKume
{
    class Program
    {
        static void Main(string[] args)
        {
            //var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RasgeleSayiUret(1000));
            var B = new SortedSet<int>(RasgeleSayiUret(1000));
            //var B = new SortedSet<int>() { 1, 2, 5, 6 };
            #region
            //SortedSet Kume Islemleri

            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine("\nB kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            //Union

            Console.WriteLine();
            // A.UnionWith(B);
            //A.IntersectWith(B);
            //A.ExceptWith(B);
            A.SymmetricExceptWith(B);
            //Console.WriteLine("\n\nA ve B kümesinin birleşimi");
            //Console.WriteLine("\n\nA ve B kümesinin kesişimi");
            //Console.WriteLine("\n\nSadece A");
            Console.WriteLine("Kesisim disindaki elemanlar");
            foreach (var item in A)
            {
                Console.Write($"{item,5}");
            }
            Console.WriteLine("\nToplam eleman sayisi : {0}",A.Count);
        }

        static List<int>RasgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0, 1000));
                
            }
            return list;
        }
    }
}
