using PropertiesTest;

PersonModel person = new PersonModel("Hartkemeyer");
person.FirstName = "Mark";
person.Age = 30;
person.SSN = "123-45-6789";

Console.WriteLine($"Name: {person.FirstName} {person.LastName}");
Console.WriteLine($"Age: {person.Age}");
Console.WriteLine($"SSN: {person.SSN}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
