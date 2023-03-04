
string exitString;
do
{
    Console.Write("Please enter your first name: ");
    string firstName = Console.ReadLine();

    if (firstName.ToLower() == "tim")
    {
        Console.WriteLine("Hello, professor");
    }
    else
    {
        Console.WriteLine($"Hi, {firstName}");
    }

    Console.Write("Exit? [yes/no] ");
    exitString = Console.ReadLine();

} while (exitString.ToLower() != "yes");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
