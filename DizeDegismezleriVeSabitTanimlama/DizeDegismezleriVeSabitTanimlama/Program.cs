using System;

namespace DizeDegismezleriVeSabitTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //örtülü değişken--tür problemi oluşmasın diye belirsiz bir tür tanımlaması yapar.
            /*var ifade = Console.ReadKey();*///Kullanıcıdan 1 karakter girdi alır. ConsoleKeyInfo tipinde değer olarak döndürür.

            //var ifade2 = Console.ReadLine();//Kullanıcıdan girilen satırı girdi olarak alır. string olarak döndürür.
            //Console.WriteLine(ifade.Key);
            //Console.WriteLine(ifade.KeyChar);

            //Console.WriteLine(ifade);
            //Console.WriteLine(ifade2);

            var ifade = "Merhaba programlama dünyası.";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade[0]);
            Console.WriteLine(ifade[1]);
            Console.WriteLine(ifade[ifade.Length-1]);


        



        }
    }
}
