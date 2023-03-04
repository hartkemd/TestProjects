using InheritanceTestApp2;

List<Phone> phones = new List<Phone>();
phones.Add(new Phone());
phones.Add(new CellPhone());
phones.Add(new SmartPhone());

foreach (var phone in phones)
{
    if (phone is CellPhone cellPhone)
    {
        cellPhone.Carrier = "";
    }

    if (phone is SmartPhone smartPhone)
    {
        smartPhone.ConnectToInternet();
    }
}
