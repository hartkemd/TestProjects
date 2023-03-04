
Console.WriteLine("Please enter two numbers to add");
double number1 = GetValidDoubleFromUser();
double number2 = GetValidDoubleFromUser();
double result = AddTwoNumbers(number1, number2);
PrintResult(result);

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static double GetValidDoubleFromUser()
{
    double output;

    bool isValidDouble;
    do
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        isValidDouble = double.TryParse(input, out output);
    } while (isValidDouble == false);
    
    return output;
}

static double AddTwoNumbers(double firstNumber, double secondNumber)
{
    double output;

    output = firstNumber + secondNumber;

    return output;
}

static void PrintResult(double result)
{
    Console.WriteLine($"The result is: {result}");
}
