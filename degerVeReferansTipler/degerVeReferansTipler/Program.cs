using System;

namespace degerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}",x,y);
            degistir(ref x,ref y);
            Console.WriteLine("{0},{1}",x,y);
            Console.ReadKey();
        }
        private static void degistir(ref int x,ref int y)
        {
            int gecici = x;
            x = y;
            y = gecici;
            Console.WriteLine("{0},{1}",x,y);

        }
    }
}
