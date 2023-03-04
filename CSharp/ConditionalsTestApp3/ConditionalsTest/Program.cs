
string prompt = "What is your name? ";
Console.Write(prompt);
string firstName = Console.ReadLine();
bool isActive = true;

//if ((firstName.ToLower() == "mark" || firstName.ToLower() == "tim") && isActive == true)
//{
//    Console.WriteLine("Your record will be selected.");
//}
//else
//{
//    Console.WriteLine("Your record will not be selected.");
//}

if (firstName.ToLower() == "mark")
{
    Console.WriteLine("Hi, Mark!");

    if (isActive == true)
    {
        Console.WriteLine("Mark is active.");
    }
    else
    {
        Console.WriteLine("Mark is not active.");
    }
}
else if (firstName.ToLower() == "tim")
{
    Console.WriteLine("Hi, Tim!");

    if (isActive == true)
    {
        Console.WriteLine("Tim is active.");
    }
    else
    {
        Console.WriteLine("Tim is not active.");
    }
}
else
{
    Console.WriteLine("Sorry, I don't recognize you.");
}

//switch (isActive)
//{
//    case true:
//        Console.WriteLine("Your record is active.");
//        break;
//    case false:
//        Console.WriteLine("Your record is not active.");
//        break;
//}

//decimal price = 2.25M;
//switch (price)
//{
//    case < 2.00M:
//        Console.WriteLine("Wow, that's cheap!");
//        break;
//    case < 2.50M:
//        Console.WriteLine("That's not a bad deal.");
//        break;
//    case 2.50M:
//        Console.WriteLine("That's normal price.");
//        break;
//    default:
//        Console.WriteLine("Unknown price");
//        break;
//}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
