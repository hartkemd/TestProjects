
(string, string) SplitCoordinates(string coordinates)
{
    string[] splitCoordinates = coordinates.Split(' ');
    string x = splitCoordinates[0];
    string y = splitCoordinates[1];

    return (x, y);
}

(string x, string y) = SplitCoordinates("A 1");
Console.WriteLine($"x = {x}, y = {y}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
