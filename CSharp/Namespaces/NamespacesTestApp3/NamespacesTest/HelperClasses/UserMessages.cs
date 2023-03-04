using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespacesTest.HelperClasses
{
    public static class UserMessages
    {
        public static string GetAString(string message)
        {
            string output;

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }
    }
}
