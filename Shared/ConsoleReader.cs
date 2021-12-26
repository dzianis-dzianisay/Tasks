using System;

namespace Shared
{
    public class ConsoleReader
    {
        public static bool TryReadDoubleFromConsole(string argumentName, out double number)
        {
            Console.WriteLine($"Введите переменную {argumentName}: ");
            string aAsStr = Console.ReadLine();
            bool result = double.TryParse(aAsStr, out number);
            if (result == true)
            {
                Console.WriteLine("Значение соответсует");
            }
            else
            {
                Console.WriteLine($"{argumentName} не соответсвует численному значению");
            }

            return result;
        }        
    }
}
