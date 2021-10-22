﻿using System;
using System.Collections.Generic;

namespace stackTemelleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //yiginOrnegi();
            //karakterYiginiOrnegi();
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();
            while (sayi>0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;  //elemanın basamak degerinde kullanmak uzere 10 uzeri kac ile carpilacigi
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x {Math.Pow(10,n-i),7}\t = {s* Math.Pow(10, n - i),7}");
                i++;
            }

        }

        private static void karakterYiginiOrnegi()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayısı: {karakterYigini.Count}");
            }

            //Ek bilgi--stack to array
            var dizi = karakterYigini.ToArray();


            Console.WriteLine("\nYığından çıkartma işlemi için bir tuşa basınız.\n");
            Console.ReadKey();
            Console.WriteLine();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı.");
            }
        }

        private static void yiginOrnegi()
        {
            //Stack tanımlama
            var karakterYigini = new Stack<char>();

            //Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());
            Console.WriteLine();

            //Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkarıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkarıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığından çıkarıldı.");
        }
    }
}
