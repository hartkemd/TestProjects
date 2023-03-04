using InstantiatedClassesTest;

PersonModel person = new PersonModel();
person.firstName = "Mark";
person.lastName = "Hartkemeyer";
person.emailAddress = "mark@markhartkemeyer.com";

Console.WriteLine(person.firstName);

PersonModel person2 = new PersonModel();
person2.firstName = "Tim";
person2.lastName = "Corey";
person2.emailAddress = "tim@iamtimcorey.com";

Console.WriteLine(person2.firstName);
Console.WriteLine();

List<PersonModel> people = new List<PersonModel>();
people.Add(person);
people.Add(person2);

person = new PersonModel();
person.firstName = "Bill";
people.Add(person);

foreach (var p in people)
{
    Console.WriteLine(p.firstName);
}

Console.WriteLine();
Console.WriteLine("Press enter to continue...");
Console.ReadLine();
