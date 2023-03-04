using InstantiatedClassesTest;

List<ProductModel> products = new List<ProductModel>();

CreateProducts(products);

PrintAllProducts(products);

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

static void CreateProducts(List<ProductModel> products)
{
    ProductModel product = new ProductModel();
    product.Id = 1;
    product.Name = "screwdriver";
    product.Price = 5.49M;
    product.Manufacturer = "Fred's Tool Company";

    products.Add(product);

    product = new ProductModel();
    product.Id = 2;
    product.Name = "wrench";
    product.Price = 6.25M;
    product.Manufacturer = "Billy's Wrenches";

    products.Add(product);

    product = new ProductModel();
    product.Id = 3;
    product.Name = "pliers";
    product.Price = 3.99M;
    product.Manufacturer = "North Tools";

    products.Add(product);
}

static void PrintAllProducts(List<ProductModel> products)
{
    foreach (var p in products)
    {
        Console.WriteLine($"Product ID: {p.Id}");
        Console.WriteLine($"Product Name: {p.Name}");
        Console.WriteLine($"Product Price: ${p.Price}");
        Console.WriteLine($"Product Manufacturer: {p.Manufacturer}");
        Console.WriteLine();
    }
}
