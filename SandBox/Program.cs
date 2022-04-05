using System;
using System.Collections.Generic;
using Shared;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("введите массив чисел, разделенных пробелом");
            string enteredString = Console.ReadLine();
            string[] splitedStrings = enteredString.Split(' ');

            double[] values = new double[splitedStrings.Length];

            int i = 0;
            foreach (string str in splitedStrings)
            {
                var parsedValue = double.Parse(str);
                values[i] = (parsedValue);
                i++;
            }

            double minValue = ValuesComparier.GetMin(values);

            Console.WriteLine($"Минимальное значение:{minValue}.");
        }
    }
}
