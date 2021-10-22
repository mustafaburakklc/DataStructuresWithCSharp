using System;

namespace cokBoyutluDiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // diziOrnegi();
            double[,] matris= new double[,] 
            { 
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            //matrisdeki sayıların toplamını ekrana yazdırma.
            //double toplam = 0;
            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        toplam += matris[i, j];
            //    }
            //}
            //Console.WriteLine("Matrisdeki sayıların toplamı: "+toplam);
            
            
            
            //matrisdeki 2 ve katı olan sayıları -1 yap.
            //for (int i = 0; i < matris.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matris.GetLength(1); j++)
            //    {
            //        if (matris[i,j]%2==0)
            //        {
            //            matris[i, j] = -1;
            //        }
            //        Console.Write($"{matris[i,j],5}");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadKey();
        }

        private static void diziOrnegi()
        {
            Console.Write("Dizi boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];
            var r = new Random();
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = r.Next(1, 10);
            }
            foreach (int s in sayilar)
            {
                Console.WriteLine($"{s,5} --> {s * s,5}");
            }
        }
    }
}
