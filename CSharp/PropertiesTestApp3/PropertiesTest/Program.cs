using PropertiesTest;

EmployeeModel employee = new EmployeeModel();
employee.FirstName = "Mark";
employee.LastName = "Hartkemeyer";
try
{
    employee.SetSalary(55555.55M);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("-Employee Info-");
Console.WriteLine($"Name: {employee.FullName}");
Console.WriteLine($"Salary: {string.Format("{0:C}", employee.GetSalary())}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
