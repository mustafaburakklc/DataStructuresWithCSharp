using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // whileOrnek();

            //whileOrnek2();

            //cifterCifter();
            
            //forOrnek1();

            //nestedForUcgen();

        }

        private static void nestedForUcgen()
        {
            Console.WriteLine("Ucgen cizdirmek icin bir sayi girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {

                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }

        private static void forOrnek1()
        {
            int a = Convert.ToInt32(Console.ReadLine()); //readline string döndürür. Convert.ToInt32  string int dönüşümü yapar.
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    continue;    //bu ifadeden sonra döngenin bir sonraki adımına atlar.
                }
                Console.WriteLine("{0,3} {1,3}", i, i * i);
            }
        }

        private static void cifterCifter()
        {
            Console.WriteLine("Bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 2;

            do
            {
                Console.Write("{0,3}", i);

                i += 2;

            } while (i <= n);
        }

        private static void whileOrnek2()
        {
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine("{0,-1} {1,-3}", sayac, sayac * sayac);   //formatlı yazım, her sayac degerinin sonuna 3 boşluk bırak.
                sayac++; //sayac+=1   sayac=sayac+1

            }
        }

        private static void whileOrnek()
        {
            int sayac = 1;
            while (sayac <= 10)
            {
                Console.WriteLine(sayac);
                sayac++;
            }
        }
    }
}
