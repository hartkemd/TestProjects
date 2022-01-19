
Console.Write("What is your age? ");
string ageString = Console.ReadLine();

//int age = int.Parse(ageString);
bool isValidAge = int.TryParse(ageString, out int age);
if (isValidAge == true)
{
    Console.WriteLine("Thanks for giving me a valid age.");
    Console.WriteLine($"Five years ago, you were {age - 5}.");
}
else
{
    Console.WriteLine("Sorry, that was not a valid age.");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
