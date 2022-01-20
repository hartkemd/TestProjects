
string[] firstNames = new string[] { "Mark", "Tim", "Sara" };

string indexString;
int index = -1;
bool isValidNumber = false;

while (isValidNumber == false || (index < 0 || index > 2))
{
    Console.Write("Please enter a number from 0 to 2: ");
    indexString = Console.ReadLine();
    isValidNumber = int.TryParse(indexString, out index);

    if (isValidNumber == true)
    {
        if (index >= 0 && index <= 2)
        {
            Console.WriteLine($"The name at position {index} is: {firstNames[index]}");
        }
        else
        {
            Console.WriteLine("That number was not between 0 and 2");
        }
    }
    else
    {
        Console.WriteLine("That was not a valid number");
    }
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
