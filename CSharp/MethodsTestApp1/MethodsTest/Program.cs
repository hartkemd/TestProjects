
PrintAuthor();
string firstName = GetUsersName("What is your first name? ");
string lastName = GetUsersName("What is your last name? ");
GreetUser(firstName, lastName);

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void PrintAuthor()
{
    Console.WriteLine("*****************************************************");
    Console.WriteLine("| This application was written by: Mark Hartkemeyer |");
    Console.WriteLine("*****************************************************");
}

static string GetUsersName(string prompt)
{
    string output;

    Console.Write(prompt);
    output = Console.ReadLine();

    return output;
}

static void GreetUser(string firstName, string lastName)
{
    Console.WriteLine($"Hello, {firstName} {lastName}!");
}
