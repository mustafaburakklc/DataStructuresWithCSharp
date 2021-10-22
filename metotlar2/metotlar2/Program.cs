using System;

namespace metotlar2
{
    class Program
    {


        static void Main(string[] args)
        {
            //double toplam = SeriToplami(5, 15, 25);
            //double toplam2 = SeriToplami(1, 2, 3, 4, 5);
            //Console.WriteLine(toplam);
            //Console.WriteLine(toplam2);
            var odenecekMiktar = SatisYap(100);
            Console.WriteLine(odenecekMiktar);
            var odenecekMiktar2 = SatisYap(100, 0.1);
            Console.WriteLine("{0,5:0.##}",odenecekMiktar2);
        }

        
        //aşırı yükleme
        public static double SatisYap(double miktar)
        {
            return miktar * 1.18;
        }
        public static double SatisYap(double miktar,double indirim)
        {
            return (miktar*(1.0-indirim))*1.18;
        }
        
        
        
        
        
        
        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in  seri)
            {
                toplam += s;
            }
            return toplam;
        }
    }
}
