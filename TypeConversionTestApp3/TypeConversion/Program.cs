
Console.Write("Are you interested in going on vacation? [true/false] ");
string isInterestedString = Console.ReadLine();
bool isValidResponse = bool.TryParse(isInterestedString, out bool isInterested);

if (isValidResponse == true)
{
    if (isInterested == true)
    {
        Console.WriteLine("You are interested in going on vacation!");
    }
    else
    {
        Console.WriteLine("I guess you'd rather keep working, huh?");
    }
}
else
{
    Console.WriteLine("That was not a valid response");
}

Console.Write("Please enter a number to add to 5.5: ");
string numberToAddString = Console.ReadLine();
bool isValidDouble = double.TryParse(numberToAddString, out double numberToAdd);
if (isValidDouble == true)
{
    Console.WriteLine($"5.5 + {numberToAdd} = {5.5 + numberToAdd}");
}
else
{
    Console.WriteLine("That was not a valid number");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
