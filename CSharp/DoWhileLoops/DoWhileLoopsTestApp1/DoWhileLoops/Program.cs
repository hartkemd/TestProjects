
//string continueResult;
//do
//{
//    Console.Write("What is your first name? ");
//    string firstName = Console.ReadLine();
//    Console.WriteLine($"Hello, {firstName}!");

//    Console.Write("Do you want to continue? [yes/no] ");
//    continueResult = Console.ReadLine();
//} while (continueResult.ToLower() == "yes");

Console.Write("What is your age? ");
string ageString = Console.ReadLine();
bool isValidAge = int.TryParse(ageString, out int age);

while (isValidAge == false)
{
    Console.WriteLine("Sorry, that was not a valid age");

    Console.Write("What is your age? ");
    ageString = Console.ReadLine();
    isValidAge = int.TryParse(ageString, out age);
}

Console.WriteLine($"In 5 years, you will be {age + 5}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
