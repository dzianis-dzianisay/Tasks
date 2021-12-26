using System;
using Shared;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            while (true)
            {                
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("а", out a);
                
                if (readResult == true)
                {
                    break;
                }
            }     
            var z1 = 2 * Math.Pow(Math.Sin(3 * Math.PI - 2 * a), 2) * Math.Pow(Math.Cos(5 * Math.PI + 2 * a), 2);
            var z2 = 1.0 / 4 - 1.0 / 4 * Math.Sin(5.0 / 2 * Math.PI - 8 * a);
            Console.WriteLine("Znachenie Z1:" + z1);
            Console.WriteLine("Znachenie Z2:" + z2);
            Console.ReadKey();
        }
    }
}
