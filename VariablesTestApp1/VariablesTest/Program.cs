
string firstName = "Mark";
string lastName = "Hartkemeyer";
string fullName = $"{firstName} {lastName}"; // string interpolation
Console.WriteLine($"My name is: {fullName}");

string filePath = "C:\\Temp\\sample.csv"; // using backslash as an escape character
Console.WriteLine($"First file path: {filePath}");
string betterFilePath = @"C:\Temp\sample.csv"; // string literal; this can be copied and used elsewhere
Console.WriteLine($"Second file path: {betterFilePath}");

int age = 0;
age = age + 5;
age += 25;
Console.WriteLine($"My age is: {age}");

double feetTall;
feetTall = 5.9;
Console.WriteLine($"I am {feetTall} feet tall");

decimal priceOfChips = 2.49M; // use decimal for money
Console.WriteLine($"The price of a bag of chips is: ${priceOfChips}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
