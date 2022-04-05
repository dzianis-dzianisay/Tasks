using System;
using Shared;

namespace Var1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, h, n;
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDecimalFromConsole("a", out a);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDecimalFromConsole("b", out b);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDecimalFromConsole("h", out h);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                bool readResult = ConsoleReader.TryReadDecimalFromConsole("n", out n);

                if (readResult == true)
                {
                    break;
                }
            }
            for (decimal x = a; x <= b; x += h)
            {
                Console.Write($"\nx = {x};");
                var Y = Math.Sin((double)x);
                Console.Write($"\tY = {Y};");
                decimal sum = 0;
                for (int k = 0; k <= n; k++)
                {
                    decimal result = Func(x, k);
                    sum += result;
                }
                Console.Write($"\tS = {sum};");
                decimal diff = (decimal)Math.Abs((double)Y - (double)sum);
                Console.WriteLine($"\t|Y - S| = {diff};");
            }
            Console.ReadKey();

        }
        public static double Factorial(int valueOfFact)
        {
            if (valueOfFact == 1 || valueOfFact == 0) return 1;

            return valueOfFact * Factorial(valueOfFact - 1);
        }

        public static decimal Func(decimal valueOfX, int k)
        {
            var expression = 2 * k + 1;
            decimal result = (decimal)(Math.Pow(-1, k) * Math.Pow((double)valueOfX, expression) / Factorial(expression));
            return result;
        }
    }
}
