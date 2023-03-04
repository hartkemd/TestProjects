byte test = 255;
Console.WriteLine($"test = {test}");
sbyte test2 = -100; // signed byte
Console.WriteLine($"test2 = {test2}");

string numberOfDaysInAWorkWeek = "5";
string numberOfDaysInAWeekend = "2";
Console.WriteLine($"Wrong number of days in a week: { numberOfDaysInAWorkWeek + numberOfDaysInAWeekend }"); // wrong

int intNumberOfDaysInAWorkWeek = 5;
int intNumberOfDaysInAWeekend = 2;
Console.WriteLine($"Number of days in a week: { intNumberOfDaysInAWorkWeek + intNumberOfDaysInAWeekend }"); // right

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
