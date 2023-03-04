
List<int> numbers = new List<int>{ 1, 2, 3, 4 };

(int min, int max) = GetMinAndMax(numbers);

Console.WriteLine($"The minimum is: {min} and the maximum is: {max}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();

(int, int) GetMinAndMax(List<int> numbers)
{
    int min = numbers[0];
    int max = numbers[0];

    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }

        if (number > max)
        {
            max = number;
        }
    }

    return (min, max);
}
