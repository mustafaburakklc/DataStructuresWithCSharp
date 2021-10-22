using System;
using System.Collections.Generic;

namespace listeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            List<int> sayilar = new List<int>();
            int x = 25;
            int[] seri = new int[] { 30, 35, 40 };
            //Ekleme
            sayilar.Add(10);
            sayilar.Add(15);
            sayilar.Add(20);
            sayilar.Add(x);
            //başka koleksiyonu tek tek ekleme
            foreach (int s in seri)
            {
                sayilar.Add(s);
            }
            //sayilar.AddRange(seri);
            //sayilar.AddRange(new int[]{40,50,60});

            //Araya ekleme
            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 60, 70 });

            //Eleman silme
            sayilar.RemoveAt(3); //indexle silme
            sayilar.RemoveAt(sayilar.IndexOf(55));  //indexini bilmediğimiz ifadeyi indexof ile bulduk.

            //tip güvenliği nedeniyle alt satır çalışmaz
            //sayilar.Add("mustafa");

            //dolaşma
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
        }
    }
}
