using System;
using Shared;

namespace Var2
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
            //double u = Math.Max(y, z) / Math.Min(Math.Max(x, y), Math.Min(y, z));
            //Console.WriteLine($"Значение u = {u}");
            double[] parametersMax = { x, y };
            double u = ValuesComparier.GetMin(x + y, y - z) / ValuesComparier.GetMax(parametersMax);
            Console.WriteLine($"Значение u = {u}");
        }
    }
}
