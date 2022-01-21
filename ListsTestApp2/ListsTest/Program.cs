
string studentName;
List<string> studentNames = new List<string>();

do
{
    Console.Write("Please enter the name of the next student, or [exit] to quit: ");
    studentName = Console.ReadLine();

    if (studentName.ToLower() != "exit" && studentName.ToLower() != "")
    {
        studentNames.Add(studentName);
    }
} while (studentName.ToLower() != "exit");

Console.WriteLine($"There are {studentNames.Count} students in the list");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
