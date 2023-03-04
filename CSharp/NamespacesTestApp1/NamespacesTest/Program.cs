using System;
using System.Collections.Generic;
using FoundationInfo.Calculators;
using NamespacesTest.Models;

namespace NamespacesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            PersonModel person = new PersonModel();
            double result = Calculations.Add(1.5, 1.6);
            Console.WriteLine(result);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
