
string firstName;
List<string> firstNames = new List<string>();

do
{
    Console.Write("What is your first name? (enter [done] to quit) ");
    firstName = Console.ReadLine();
    firstNames.Add(firstName);
} while (firstName.ToLower() != "done");

Console.WriteLine();

foreach (var name in firstNames)
{
    if (name.ToLower() != "done")
    {
        Console.WriteLine($"Hello, {name}");
    }
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
