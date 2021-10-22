﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace listGeneric
{
   
    public class Sehir :IComparable<Sehir>
    {
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public override string ToString()
        {
            return $"{PlakaNo,-5} {SehirAdi,-15}";
        }

        public int CompareTo(Sehir other)
        {
            if (this.PlakaNo<other.PlakaNo)
            {
                return -1;
            }
            else if (this.PlakaNo==other.PlakaNo)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public int PlakaNo { get; set; }
        public  string SehirAdi { get; set; }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            //List

            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")
            };
            sehirler.Add(new Sehir(1,"Adana"));
            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }
    }
}
