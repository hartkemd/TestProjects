
using DemoLibrary.Models;

PersonModel person = new PersonModel();

Console.Write("What is your first name? ");
person.FirstName = Console.ReadLine();

Console.Write("What is your last name? ");
person.LastName = Console.ReadLine();

Console.WriteLine($"Your name is: {person.FirstName} {person.LastName}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
