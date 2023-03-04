using NamespacesTest.HelperClasses;
using NamespacesTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespacesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel();
            person.FirstName = UserMessages.GetAString("Please enter a first name: ");
            person.LastName = UserMessages.GetAString("Please enter a last name: ");

            Console.WriteLine($"The person you entered was: {person.FirstName} {person.LastName}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
