using System;
using System.Collections.Generic;

namespace queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //queueGiris();
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };
            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();
            foreach (char k in sesliHarfler)
            {
                Console.WriteLine($"{k,-5} kuyruğa eklensin mi? [e/h]");
                secim = Console.ReadKey();
                Console.WriteLine();
                if (secim.Key==ConsoleKey.E)
                {
                    kuyruk.Enqueue(k);
                    Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktan elemanlarin kaldirilmasi işlemi için Esc tuşuna basiniz.");
            secim = Console.ReadKey();
            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{kuyruk.Peek(),5} kuyruktan çıkartılıyor.");
                    Console.WriteLine($"{kuyruk.Dequeue(),5} kuyruktan çıkartıldı.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {kuyruk.Count}");

                }
            }

        }

        private static void queueGiris()
        {
            //Queue tanımlama
            var karakterKuyrugu = new Queue<char>();

            //Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            karakterKuyrugu.Enqueue('i');
            karakterKuyrugu.Enqueue('o');
            karakterKuyrugu.Enqueue('u');

            //Diziye atama
            var dizi = karakterKuyrugu.ToArray();

            //Çıkarma
            karakterKuyrugu.Dequeue();  //ilk gireni silecek yani 'a' ifadesi kuyruktan çıkarılır.

            //Kuyruğun başındaki eleman , yani ilk girilmiş eleman , a silindiği için e
            Console.WriteLine($"Kuyruğun başındaki eleman(ilk eklenen): {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkarıldı.");
            Console.WriteLine($"Eleman sayisi: {karakterKuyrugu.Count}");
        }
    }
}
