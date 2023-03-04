
//string[] firstNames = new string[10];
//firstNames[0] = "Mark";
//firstNames[1] = "Tim";
//firstNames[3] = "Carl";

//Console.WriteLine($"My array has {firstNames[0]}, {firstNames[1]}, {firstNames[3]}");

string data = "Mark,Tim,Carl";
string[] firstNames = data.Split(',');

Console.WriteLine($"The third item in the array is: {firstNames[2]}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
