using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1;
            //double pi = 3.14;
            //char secim = 'e';
            //string isim = "mustafa";
            //bool dogruMu = false;
            //Console.ReadKey();

            //string isim;
            //isim = "Mustafa";
            //Console.WriteLine("merhaba "+isim+".");
            //isim = "Burak";
            //Console.WriteLine("merhaba sayin " + isim + ".");

            DegiskenBasitOrnek();

        }

        private static void DegiskenBasitOrnek()
        {
            int sayi = 5;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi + 2);
            Console.WriteLine(sayi * sayi);
            Console.WriteLine(sayi - 5);
        }
    }
}
