
List<string> groceryItems = new List<string>();

groceryItems.Add("milk");
groceryItems.Add("cereal");
groceryItems.Add("oatmeal");
groceryItems.Add("milk");

Console.WriteLine($"Grocery items: {groceryItems[0]}, {groceryItems[1]}, {groceryItems[2]}, {groceryItems[3]}");

bool milkWasRemoved = groceryItems.Remove("milk");

if (milkWasRemoved == true)
{
    Console.WriteLine("milk was removed from the list");
}
else
{
    Console.WriteLine("milk was not removed from the list");
}

Console.WriteLine($"Grocery items, after removing first milk: {groceryItems[0]}, {groceryItems[1]}, {groceryItems[2]}");

milkWasRemoved = groceryItems.Remove("milk");

if (milkWasRemoved == true)
{
    Console.WriteLine("milk was removed from the list");
}
else
{
    Console.WriteLine("milk was not removed from the list");
}

Console.WriteLine($"Grocery items, after removing second milk: {groceryItems[0]}, {groceryItems[1]}");

milkWasRemoved = groceryItems.Remove("milk"); // try to remove milk again, but it's not in the list anymore

if (milkWasRemoved == true)
{
    Console.WriteLine("milk was removed from the list");
}
else
{
    Console.WriteLine("milk was not removed from the list");
}

bool listContainsMilk = groceryItems.Contains("milk");

if (listContainsMilk == true)
{
    Console.WriteLine("we have milk on our list");
}
else
{
    Console.WriteLine("we do not have milk on our list");
}

groceryItems.Clear(); // we went shopping, so now our list is empty!

Console.WriteLine(); // breakpoint here to check locals to see if list has been cleared
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
