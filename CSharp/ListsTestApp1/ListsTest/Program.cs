
List<string> firstNames = new List<string>();

firstNames.Add("Mark");
firstNames.Add("Tim");
firstNames.Add("Sue");

Console.WriteLine($"The second element is: {firstNames[1]}");

firstNames.Remove("Tim");

Console.WriteLine($"The second element is: {firstNames[1]}");

firstNames[1] = firstNames[1].ToUpper();

Console.WriteLine($"The second element is: {firstNames[1]}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
