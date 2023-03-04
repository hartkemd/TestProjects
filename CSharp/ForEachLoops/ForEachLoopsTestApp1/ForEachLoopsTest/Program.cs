
List<string> firstNames = new List<string>() { "Mark", "Tim", "Sam", "Linda" };

Console.WriteLine("The names in our list are:");
foreach (var name in firstNames)
{
    Console.WriteLine(name);
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
