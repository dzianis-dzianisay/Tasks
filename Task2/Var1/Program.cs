using System;
using Shared;

namespace Var1
{
    class Program
    {
        static void Main(string[] args)
        {
            double k, z;
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
                ApplyFirstBranchCalculator(k, z);
            }
            else if (k >= 1)
            {
                ApplySecondBranchCalculator(k, z);
            }
            Console.ReadKey();
        }

        private static void ApplyFirstBranchCalculator(double k, double z)
        {
            var x = k * Math.Pow(z, 3);
            var y = Math.Pow(Math.Log(1 + Math.Pow(x, 2)) + Math.Cos(x + 1), Math.Pow(Math.E, k * x));
            Console.WriteLine($"Вычисление ведем по ветви 1 \nЗначение y = {y} ");
        }

        private static void ApplySecondBranchCalculator(double k, double z)
        {
            var x = z * (z + 1);
            var y = Math.Pow(Math.Log(1 + Math.Pow(x, 2)) + Math.Cos(x + 1), Math.Pow(Math.E, k * x));
            if (double.IsInfinity(y))
            {
                Console.WriteLine($"у = бесконечность");
            }
            else
            {
                Console.WriteLine($"Вычисление ведем по ветви 2\nЗначение y = {y} ");
            }
        }
    }
}
