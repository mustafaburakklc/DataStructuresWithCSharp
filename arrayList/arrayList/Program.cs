using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tanımlama
            ArrayList arrayList = new ArrayList()
            {
                10,"BTK Akademi",true,'e'
            };

            //Ekleme
            /*arrayList.Add(10);  //boxing, verilen ifadeler obje olarak tutuluyor.
            arrayList.Add("BTK Akademi");
            arrayList.Add(true);
            arrayList.Add('e');*/


            //Dolaşma
            //foreach (var e in arrayList)
            //{
            //    Console.WriteLine($"{e} ");
            //}

            int[] sayilar = new int[] { 23, 44, 55 };
            arrayList.AddRange(sayilar);

            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
            Console.WriteLine();
            //elemana erişme
            Console.WriteLine(arrayList[4]);
            //elemana erişme-atama
            int x = (int)arrayList[0];   //kutudan çıkarma
            Console.WriteLine(x+10);

            //eleman silme
            //arrayList.Remove(10);
            //arrayList.RemoveAt(1);
            arrayList.RemoveRange(3,3);
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
        }
    }
}
