using System;
using Shared;

namespace Var2
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
                var Y = FuncOfY(x);
                Console.Write($"\tY = {Y};");
                decimal sum = 0;
                for (int k = 1; k <= n; k++)
                {
                    decimal result = FuncOfS(x, k);
                    sum += result;
                }
                Console.Write($"\tS = {sum};");
                decimal diff = (decimal)Math.Abs((double)Y - (double)sum);
                Console.WriteLine($"\t|Y - S| = {diff};");
            }
            Console.ReadKey();

        }

        public static decimal FuncOfS(decimal valueOfX, int k)
        {
            var expression = 2 * k * (2 * k - 1);
            decimal result = (decimal)Math.Pow(-1, k +1) * (decimal)Math.Pow((double)valueOfX, 2 * k) / expression;
            return result;
        }
        public static decimal FuncOfY(decimal valueOfX)
        {
            decimal result = valueOfX * (decimal)Math.Atan((double)valueOfX) - (decimal)Math.Log((Math.Sqrt(1 + Math.Pow((double)valueOfX, 2))));
            return result;
        }
    }
}
