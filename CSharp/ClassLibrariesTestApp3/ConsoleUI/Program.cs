
using DemoLibrary.Models;

EmployeeModel employee = new EmployeeModel();
employee.FirstName = "Mark";
employee.LastName = "Hartkemeyer";
employee.Salary = 50000M;

Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName} | Salary: ${employee.Salary}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
