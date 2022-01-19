
Console.Write("What is your age? ");
string ageString = Console.ReadLine();

bool isValidAge = int.TryParse(ageString, out int age);
if (isValidAge == true)
{
    int yearDifference = 2022 - 2000;
    int ageIn2000 = age - yearDifference;
    if (ageIn2000 > 1 || ageIn2000 == 0)
    {
        Console.WriteLine($"You were {ageIn2000} in 2000");
    }
    else if (ageIn2000 == 1)
    {
        Console.WriteLine("You were 1 year old in 2000");
    }
    else if (ageIn2000 < 0)
    {
        Console.WriteLine("You were not born yet in 2000");
    }
}
else
{
    Console.WriteLine("That was not a valid age");
}

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
