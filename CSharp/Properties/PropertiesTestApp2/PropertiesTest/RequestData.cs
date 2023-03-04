using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTest
{
    public static class RequestData
    {
        public static string GetAString(string message)
        {
            Console.Write(message);
            string output = Console.ReadLine();

            while (output == "")
            {
                Console.WriteLine("That was not a valid input. Please try again.");
                Console.Write(message);

                output = Console.ReadLine();
            }

            return output;
        }
    }
}
