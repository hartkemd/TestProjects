using NamespacesTest.Calculators;
using System;

namespace NamespacesTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = BasicCalculator.Multiply(3, 4);
            Console.WriteLine($"3 * 4 = {result}");

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
