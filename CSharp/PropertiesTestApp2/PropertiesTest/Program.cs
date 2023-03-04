using PropertiesTest;

AddressModel address = new AddressModel();
address.StreetAddress = RequestData.GetAString("Please enter a street address (ex: 1234 Main St.): ");
address.City = RequestData.GetAString("Please enter a city: ");
address.State = RequestData.GetAString("Please enter a state (ex: OH): ");
address.ZipCode = RequestData.GetAString("Please enter a zip code (ex: 12345 or 12345-6789): ");

UserMessages.PrintAddressToConsole(address);

Console.WriteLine("Press enter to continue...");
Console.ReadLine();
