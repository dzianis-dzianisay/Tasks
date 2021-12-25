using System;
using Shared;

namespace Var1
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, z, x;              
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("k", out k);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("z", out z);

                if (readResult == true)
                {
                    break;
                }
            }            
            if(k < 1)
            {
                Console.WriteLine($"Вычисление ведем по ветви 1");
                x = k * Math.Pow(z, 3);
                var y = Math.Pow(Math.Log(1 + Math.Pow(x, 2)) + Math.Cos(x + 1), Math.Pow(Math.E, k * x));
                Console.WriteLine($"Значение y = {y} ");                
            }
            else if (k >= 1)
            {
                Console.WriteLine($"Вычисление ведем по ветви 2");
                x = z * (z + 1);
                var y = Math.Pow(Math.Log(1 + Math.Pow(x, 2)) + Math.Cos(x + 1), Math.Pow(Math.E, k * x));
                if(double.IsInfinity(y))
                {
                    Console.WriteLine($"у = бесконечность");
                }
                else
                {
                    Console.WriteLine($"Значение y = {y} ");
                }                
            }
            Console.ReadKey();
        }
    }
}
