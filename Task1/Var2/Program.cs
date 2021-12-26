using System;
using Shared;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("a", out a);

                if (readResult)
                {
                    break;
                }
            }
            var z1 = Math.Cos(a) + Math.Sin(a) + Math.Cos(3 * a) + Math.Sin(3 * a);
            var z2 = 2 * Math.Sqrt(2 * Math.Cos(a)) * Math.Sin(Math.PI / 4 + 2 * a);
            Console.WriteLine("Значение z1: " +z1 );
            Console.WriteLine("Значение z2: " +z2 );
            Console.ReadKey();
        }
    }
}
