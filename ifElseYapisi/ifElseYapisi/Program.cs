using System;

namespace ifElseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //tekMiCiftMi();

            //mutlakDeger();

            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdir.");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Kucuk karakter");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Buyuk karakter");
            }
            else
            {
                Console.WriteLine("Bilinmeyen karakter");
                
            }
            Console.WriteLine(k);
        }

        private static void mutlakDeger()
        {
            //mutlak değer
            Console.WriteLine("Mutlak degeri aranan sayiyi girin: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }

        private static void tekMiCiftMi()
        {
            //tek / çift
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayidir.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayidir.");
            }
        }
    }
}
