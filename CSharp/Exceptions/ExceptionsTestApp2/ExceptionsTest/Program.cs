
try
{
    ThrowExceptionAfterFiveIterations();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void ThrowExceptionAfterFiveIterations()
{
    for (int i = 0; i < 5; i++)
    {
        if (i == 4)
        {
            throw new Exception();
        }
    }
}
