using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesTest
{
    public static class UserMessages
    {
        public static void PrintAddressToConsole(AddressModel address)
        {
            Console.WriteLine();
            Console.WriteLine("-Full Address-");
            Console.WriteLine(address.FullAddress);
            Console.WriteLine();
        }
    }
}
