using System;
using System.Collections;

namespace DizilerVeAlternatifDizi
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array|Dizi
            //ilkel dizi tanımlama
            int[] sayilar = new int[] { 5, 3, 8, 10, 2,18,23,44,55,6,34,19};
            //array objesiyle dizi tanımalam
            var numbers = Array.CreateInstance(typeof(int), sayilar.Length); //yeni bir dizi tanımlama yöntemi


            sayilar.CopyTo(numbers, 0); //sayilar dizisi elemanlarıyla numbers dizisini doldurdum.
            var arr = new ArrayList(numbers); //arr ismin arraylist oluşturdum, numbers dizisini kullanıyor.
            
            
            Array.Sort(sayilar);
            Array.Sort(numbers);
            Array.Clear(sayilar, 2, 3);
            
            Console.WriteLine(Array.IndexOf(sayilar, 100));    //Array.IndexOf(dizi,aranan)  bulursa indeksini , bulamazsa -1 döndürür.
            arr.Sort();
           

            //Dolaşma
            for (int i = 0; i < numbers.Length; i++)
            {
                //Console.WriteLine("sayilar[{0}] = {1} - numbers[{0}] = {2}",
                //    i,
                //    sayilar[i],
                //    numbers.GetValue(i));


                Console.WriteLine($"sayilar[{i}] = {sayilar[i],3}----" +
                    $"numbers[{i}] = {numbers.GetValue(i),3}---" +
                    $"arr[{i}] = {arr[i],3}");
            }

            


            
        }
    }
}
