using InstantiatedClassesTest;

PersonModel person = new PersonModel();
person.FirstName = "Mark";
person.LastName = "Hartkemeyer";

AddressModel address = new AddressModel();
address.StreetAddress = "1234 Main St.";
address.City = "Cincinnati";
address.State = "OH";
address.ZipCode = "45201";

person.HomeAddress = address;

Console.WriteLine($"{person.FirstName} {person.LastName} lives at: " +
    $"{person.HomeAddress.StreetAddress}, {person.HomeAddress.City}, {person.HomeAddress.State} {person.HomeAddress.ZipCode}");

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
