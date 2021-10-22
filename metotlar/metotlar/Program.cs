using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int secilen=karsilastir(3, 5);
            Console.WriteLine($"Metot bitti. Secilen sayi: {secilen}");*/
            var x = KareAl(3);
            double y = KareAl(x);
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        public static int karsilastir(int sayi1,int sayi2)
        {
            //if (sayi1>sayi2)
            //{
            //    return sayi1;
            //}
            //else
            //{
            //    return sayi2;
            //}
            return sayi1 > sayi2 ? sayi1 : sayi2;
        }
        public static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;

        }


    }
}
