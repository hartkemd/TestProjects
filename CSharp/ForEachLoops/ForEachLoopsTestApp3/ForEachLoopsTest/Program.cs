
Dictionary<int, decimal> prices = new Dictionary<int, decimal>();
prices.Add(2015, 2.00M);
prices.Add(2016, 2.25M);
prices.Add(2017, 2.25M);
prices.Add(2018, 2.30M);
prices.Add(2019, 3.00M);
prices.Add(2020, 2.50M);

foreach (var price in prices)
{
    Console.WriteLine($"The price of a bag of chips was: ${price.Value} in {price.Key}");
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
