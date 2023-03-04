
bool isActive = false;
if (isActive == true)
{
    Console.WriteLine("The record is active.");
}
else
{
    Console.WriteLine("The record is not active.");
}

int mood = 0;
if (mood < 0)
{
    Console.WriteLine("You are in a bad mood.");
}
else if (mood == 0)
{
    Console.WriteLine("You are in a neutral mood.");
}
else if (mood > 0)
{
    Console.WriteLine("You are in a good mood!");
}

//switch (mood)
//{
//    case < 0:
//        Console.WriteLine("You are in a bad mood.");
//        break;
//    case 0:
//        Console.WriteLine("You are in a neutral mood.");
//        break;
//    case > 0:
//        Console.WriteLine("You are in a good mood!");
//        break;
//}

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
