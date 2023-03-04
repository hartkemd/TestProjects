
try
{
    BadCall();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void BadCall()
{
    int[] ages = new int[] { 1, 3, 5 };

    for (int i = 0; i <= ages.Length; i++)
    {
        //try
        //{
            Console.WriteLine(ages[i]);
        //}
        //catch (Exception ex)
        //{
        //    //Console.WriteLine(ex); // might be appropriate for a logging system
        //    Console.WriteLine(ex.Message); // might be appropriate for a user
        //    throw; // throw the exception, as if we didn't handle it
        //}
    }
}
