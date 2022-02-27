
(double x, double y, double z) = Get3dCoordinates();

Console.WriteLine($"The object is located at coordinates: {x}, {y}, {z}");

Console.WriteLine("Press enter to continue...");
Console.ReadLine();

(double, double, double) Get3dCoordinates()
{
    double x, y, z;

    x = 1.5;
    y = 2.0;
    z = 1.75;

    return (x, y, z);
}
