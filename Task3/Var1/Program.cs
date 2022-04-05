using System;
using Shared;

namespace Var1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            while (true)
            {
                double[] valuesToCompare;
                valuesToCompare = new double[] { };
                bool readResult = ConsoleReader.TryReadUniqueDoubleFromConsole("x", valuesToCompare, out x);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                double[] valuesToCompare;
                valuesToCompare = new double[] { x };
                bool readResult = ConsoleReader.TryReadUniqueDoubleFromConsole("y", valuesToCompare, out y);

                if (readResult == true)
                {
                    break;
                }
            }
            while (true)
            {
                double[] valuesToCompare;
                valuesToCompare = new double[] { x, y };
                bool readResult = ConsoleReader.TryReadUniqueDoubleFromConsole("z", valuesToCompare, out z);

                if (readResult == true)
                {
                    break;
                }
            }
            //double m = Math.Max(Math.Max(x, y), z) / Math.Min(x, y) + 5;
            //Console.WriteLine($"Значение m = {m}");
            double[] parametersMax = { x, y, z };
            double m = ValuesComparier.GetMax(parametersMax) / ValuesComparier.GetMin(x, y, z) + 5;
            Console.WriteLine($"Значение m = {m}");
        }
    }
}
