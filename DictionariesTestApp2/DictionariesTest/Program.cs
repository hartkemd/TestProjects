
Dictionary<int, string> employees = new Dictionary<int, string>();
employees.Add(1, "Mark");
employees.Add(2, "Tim");
employees.Add(3, "Sue");
employees.Add(4, "Bob");

Console.Write("Please enter your employee ID: ");
string idString = Console.ReadLine();
bool isValidId = int.TryParse(idString, out int id);

if (isValidId == true && id > 0 && id < 5)
{
    Console.WriteLine($"Your name is: {employees[id]}");
}
else
{
    Console.WriteLine("That was not a valid ID");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
