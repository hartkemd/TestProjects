
try
{
    ThrowException();
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("This is from the finally block.");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void ThrowException()
{
    int total = 0;

    for (int i = 4; i >= 0; i--)
    {
        total += 10 / i;
        Console.WriteLine(total);
    }
}
