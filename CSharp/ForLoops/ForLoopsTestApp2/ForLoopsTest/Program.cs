
Console.Write("Please enter a comma-separated list of first names (no spaces): ");
string firstNames = Console.ReadLine();
string[] separatedFirstNames = firstNames.Split(',');

for (int i = 0; i < separatedFirstNames.Length; i++)
{
    Console.WriteLine($"Hello, {separatedFirstNames[i]}");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
