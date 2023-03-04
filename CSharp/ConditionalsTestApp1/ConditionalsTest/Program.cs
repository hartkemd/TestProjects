
Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

//if (firstName.ToLower() == "mark")
//{
//    Console.WriteLine("Hi, Mark!");
//}

//if (firstName.ToLower() == "mark")
//{
//    Console.WriteLine("Hi, Mark!");
//}
//else
//{
//    Console.WriteLine("Hello, other person!");
//}

//if (firstName.ToLower() == "mark")
//{
//    Console.WriteLine("Hi, Mark!");
//}
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hi, Tim!");
//}
//else
//{
//    Console.WriteLine("Hello, other person!");
//}

Console.Write("What is your last name? ");
string lastName = Console.ReadLine();

//if (firstName.ToLower() == "mark" && lastName.ToLower() == "hartkemeyer")
//{
//    Console.WriteLine("Hello, myself!");
//}
//else if (firstName.ToLower() == "mark")
//{
//    Console.WriteLine("Hello, other Mark!");
//}

//if (firstName.ToLower() == "mark" || firstName.ToLower() == "madalin")
//{
//    Console.WriteLine("Hello, student!");
//}

if ((firstName.ToLower() == "mark" && lastName.ToLower() == "hartkemeyer") ||
    (firstName.ToLower() == "madalin" && lastName.ToLower() == "cernat"))
{
    Console.WriteLine("Hello, student!");
}
else
{
    Console.WriteLine("Hello, other person!");
}

//int age = 35;
//if (age > 40)
//{

//}
//else if (age >= 21)
//{

//}
//else if (age >= 18)
//{

//}

//switch (firstName.ToLower())
//{
//    case "mark":
//        Console.WriteLine("Hello, Mark!");
//        break;
//    case "tim":
//        Console.WriteLine("Hi, Tim!");
//        break;
//    default:
//        Console.WriteLine("Hello, unknown person!");
//        break;
//}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
