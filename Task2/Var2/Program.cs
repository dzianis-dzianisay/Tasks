using Shared;
using System;

namespace Var2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, z;
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("a", out a);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDoubleFromConsole("b", out b);

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
            if (z < a * b)
            {
                ApplyFirstBranchCalculator(a, b, z);
            }
            else if (z >= a * b)
            {
                ApplySecondBranchCalculator(a, b, z);
            }
            Console.ReadKey();
        }

        private static void ApplyFirstBranchCalculator(double a, double b, double z)
        {
            var sqrtExp = Math.Pow(a, 2) + Math.Pow(b, 2) * z;
            if (sqrtExp < 0)
            {
                Console.WriteLine($"Невозможно извлечь корень из отрицательного числа");
            }
            else
            {
                var x = Math.Sqrt(sqrtExp);
                var numerator = a * x + b * Math.Cos(Math.Sqrt(x));
                var denumerator = x + a * b;
                if (denumerator == 0)
                {
                    Console.WriteLine($"Делить на ноль нельзя");
                }
                else
                {
                    var y = numerator / denumerator;
                    Console.WriteLine($"Вычисление ведем по ветви 1\nЗначение y = {y} ");
                }
            }
        }

        private static void ApplySecondBranchCalculator(double a, double b, double z)
        {
            var x = Math.Pow(Math.Sin(z), 2) + Math.Abs(a * b * z);
            var numerator = a * x + b * Math.Cos(Math.Sqrt(x));
            var denumerator = x + a * b;
            if (denumerator == 0)
            {
                Console.WriteLine($"Делить на ноль нельзя");
            }
            else
            {
                var y = numerator / denumerator;
                Console.WriteLine($"Вычисление ведем по ветви 2 \nЗначение y = {y} ");
            }
        }
    }
}
