
string direction;
do
{
    Console.Write("Which direction would you like to move? [north, south, east, west, exit] ");
    direction = Console.ReadLine();

    if (direction.ToLower() == "north")
    {
        Console.WriteLine("You move North.");
    }
    else if (direction.ToLower() == "south")
    {
        Console.WriteLine("You move South.");
    }
    else if (direction.ToLower() == "east")
    {
        Console.WriteLine("You move East.");
    }
    else if (direction.ToLower() == "west")
    {
        Console.WriteLine("You move West.");
    }
} while (direction.ToLower() != "exit");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
