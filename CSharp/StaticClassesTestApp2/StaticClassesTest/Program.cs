using StaticClassesTest;

double x = RequestData.GetADouble("Please enter a first number: ");
double y = RequestData.GetADouble("Please enter a second number: ");

double resultOfAddition = CalculateData.Add(x, y);
double resultOfSubtraction = CalculateData.Subtract(x, y);
double resultOfMultiplication = CalculateData.Multiply(x, y);
double resultOfDivision = CalculateData.Divide(x, y);

UserMessages.PrintResult($"{x} + {y} = {resultOfAddition}");
UserMessages.PrintResult($"{x} - {y} = {resultOfSubtraction}");
UserMessages.PrintResult($"{x} * {y} = {resultOfMultiplication}");
UserMessages.PrintResult($"{x} / {y} = {resultOfDivision}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
