using System;

namespace Shared
{
    public class ConsoleReader
    {
        public static bool TryReadUniqueDoubleFromConsole(string argumentName, double[] valuesToCompare, out double enteredValue)
        {
            bool result = TryReadDoubleFromConsole(argumentName, out enteredValue);
            if (result == false)
            {
                return false;
            }

            foreach (double valueToCompare in valuesToCompare)
            {
                if (enteredValue == valueToCompare)
                {
                    Console.WriteLine($"{argumentName} соответсвует введенному ранее числу, это не допустимо.");
                    return false;
                }
            }

            return result;
        }        

        public static bool TryReadDoubleFromConsole(string argumentName, out double number)
        {
            Console.WriteLine($"Введите переменную {argumentName}: ");
            string aAsStr = Console.ReadLine();
            bool result = double.TryParse(aAsStr, out number);
            if (result == false)
            {
                Console.WriteLine($"{argumentName} не соответсвует численному значению");
                return false;
            }

            return result;
        }

        public static bool TryReadDecimalFromConsole(string argumentName, out decimal number)
        {
            Console.WriteLine($"Введите переменную {argumentName}: ");
            string aAsStr = Console.ReadLine();
            bool result = decimal.TryParse(aAsStr, out number);
            if (result == false)
            {
                Console.WriteLine($"{argumentName} не соответсвует численному значению");
                return false;
            }

            return result;
        }


        public static ParseResult TryReadUniqueDoubleFromConsoleNew(string argumentName, double[] valuesToCompare, out double enteredValue)
        {
            ParseResult result = TryReadDoubleFromConsoleNew(argumentName, out enteredValue);
            if (result.Succeeded == false)
            {
                return result;
            }

            foreach (double valueToCompare in valuesToCompare)
            {
                if (enteredValue == valueToCompare)
                {
                    return new ParseResult { Succeeded = false, Error = $"{argumentName} соответсвует введенному ранее числу, это не допустимо." };
                }
            }

            return new ParseResult { Succeeded = true, Error = null };
        }

        public static ParseResult TryReadDoubleFromConsoleNew(string argumentName, out double number)
        {
            Console.WriteLine($"Введите переменную {argumentName}: ");
            string aAsStr = Console.ReadLine();
            bool result = double.TryParse(aAsStr, out number);
            if (result == false)
            {
                return new ParseResult { Succeeded = false, Error = $"{argumentName} не соответсвует численному значению" };
            }

            return new ParseResult { Succeeded = true, Error = null };
        }
    }
}
