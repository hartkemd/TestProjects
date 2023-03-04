using StaticClassesTest;

string firstName = RequestData.GetAString("What is your first name? ");

UserMessages.PrintWelcomeMessage(firstName);

double x = RequestData.GetADouble("Please enter a first number to add: ");
double y = RequestData.GetADouble("Please enter a second number to add: ");

double result = CalculateData.Add(x, y);

UserMessages.PrintResultMessage($"{x} + {y} = {result}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
