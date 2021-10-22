using System;

namespace struct2

{

    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}" ;
        }
        //default constructor --ctor tab
        public Nokta(int x,int y)
        {
            X = x;
            Y = y;
        }

        //Yapımıza yeni üye eklemek
        public void SetOrigin()
        {
            X = 0;
            Y = 0;
        }

        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //struct - deger tipli
            var n1 = new Nokta(3,4);
            Console.WriteLine("n1 ilk degeri: "+n1);
            n1.Degistir();
            Console.WriteLine("n1 degistir uygulanmis degeri: "+n1);
            var n2 = n1;
            Console.WriteLine("n1 n2 ye atandi n2: "+n2);
            n2.X = -1 * n2.X;

            Console.WriteLine("n2 ye islem uygulandiktan sonra n1: "+n1);
            Console.WriteLine("n2 ye islem uygulandiktan sonra n2: "+n2);



        }
    }
}
