
int[] ages = new int[3];
int count = 0;

do
{
    Console.Write("Please enter an age: ");
    ages[count] = int.Parse(Console.ReadLine()); // we trust the user is entering valid integers
    count++;
} while (count <= 2);

Console.WriteLine($"The ages you entered were: {ages[0]}, {ages[1]}, and {ages[2]}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
