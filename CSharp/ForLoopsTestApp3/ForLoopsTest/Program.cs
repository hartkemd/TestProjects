
for (int i = 100; i > 0; i -= 3)
{
    Console.WriteLine(i);
}

Console.WriteLine();

List<bool> switchPositions = new List<bool>() { true, true, false, false, true };

for (int i = 0; i < switchPositions.Count; i++)
{
    Console.WriteLine($"Switch {i + 1}: {switchPositions[i]}");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
