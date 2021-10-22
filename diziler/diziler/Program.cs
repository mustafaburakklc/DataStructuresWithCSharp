using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //tanımlama
            //int[] numaralar;

            //başlatma
            //numaralar = new int[3];

            //aynı satırda tanımalama ve başlatma
            //int[] numaralar = new int[3];
            //numaralar[0] = 3;
            //numaralar[1] = 5;
            //numaralar[2] = 7;

            //aynı satırda tanımlama,başlatma ve atama

            int[] numaralar = new int[5] { 3, 5, 7,8,10 };
            // int [] numaralar = new int[] {3,5,7,8,10};
            // int [] numaralar = {3,5,7,8,10};
            

            for (int i = 0; i < numaralar.Length; i++)
            {
                // Console.WriteLine(numaralar[i]);

                Console.WriteLine($"Numaralar[{i}] = {numaralar[i]}");
            }


        }
    }
}
