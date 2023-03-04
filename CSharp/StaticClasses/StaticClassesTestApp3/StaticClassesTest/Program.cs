using StaticClassesTest;

double feet = RequestData.GetADouble("Please enter a number of feet to convert to meters: ");
LengthConversion.ConvertFeetToMeters(feet);
double meters = LengthConversion.result;

UserMessages.PrintResult($"{feet} feet = {meters} meters");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
