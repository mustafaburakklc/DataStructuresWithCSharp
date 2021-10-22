using System;

namespace veriTurlerininAltVeUstLimitleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //8-bit integer

            Console.WriteLine(nameof(SByte));
            Console.WriteLine($"Alt limit     :{SByte.MinValue,20}");
            Console.WriteLine($"Ust limit     :{SByte.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(SByte),20}");
            Console.WriteLine();
            //Console.ReadKey();
            

            //Unsigned 8-bit integer

            Console.WriteLine(nameof(Byte));
            Console.WriteLine($"Alt limit     :{Byte.MinValue,20}");
            Console.WriteLine($"Ust limit     :{Byte.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(Byte),20}");
            Console.WriteLine();

            //Signed 16-bit integer

            Console.WriteLine(nameof(Int16));
            Console.WriteLine($"Alt limit     :{Int16.MinValue,20}");
            Console.WriteLine($"Ust limit     :{Int16.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(Int16),20}");
            Console.WriteLine();

            //Unsigned 16-bit integer

            Console.WriteLine(nameof(UInt16));
            Console.WriteLine($"Alt limit     :{UInt16.MinValue,20}");
            Console.WriteLine($"Ust limit     :{UInt16.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(UInt16),20}");
            Console.WriteLine();

            //Signed 32-bit integer

            Console.WriteLine(nameof(Int32));
            Console.WriteLine($"Alt limit     :{Int32.MinValue,20}");
            Console.WriteLine($"Ust limit     :{Int32.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(Int32),20}");
            Console.WriteLine();

            //Unsigned 32-bit integer

            Console.WriteLine(nameof(UInt32));
            Console.WriteLine($"Alt limit     :{UInt32.MinValue,20}");
            Console.WriteLine($"Ust limit     :{UInt32.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(UInt32),20}");
            Console.WriteLine();


            //double 64-bit

            Console.WriteLine(nameof(Double));
            Console.WriteLine($"Alt limit     :{Double.MinValue,20}");
            Console.WriteLine($"Ust limit     :{Double.MaxValue,20}");
            Console.WriteLine($"Boyut(byte)   :{sizeof(Double),20}");
            Console.WriteLine();












            Console.ReadKey();



        }
    }
}
