using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesTest
{
    public static class RequestData
    {
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberString = Console.ReadLine();

            bool isValidDouble = double.TryParse(numberString, out double output);

            while (isValidDouble == false)
            {
                Console.WriteLine("That was not a valid double. Please try again.");
                Console.Write(message);

                numberString = Console.ReadLine();

                isValidDouble = double.TryParse(numberString, out output);
            }

            return output;
        }
    }
}
