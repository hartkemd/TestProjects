
GreetUser();

string firstName = GetUsersFirstName();

GreetUserByName(firstName);

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void GreetUser()
{
    Console.WriteLine("Welcome to my app.");
}

static string GetUsersFirstName()
{
    string output;

    Console.Write("What is your first name? ");
    output = Console.ReadLine();

    return output;
}

static void GreetUserByName(string firstName)
{
    Console.WriteLine($"Welcome, {firstName}!");
}
