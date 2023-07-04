using AddressBook.Model;
using AddressBook.Utils;

try
{
    AddressCatalog addressBook = new AddressCatalog(PeopleCatalog.People);
    Person p = new Person(
        "Teresa Diego Salas lkjfalkdjkfl",
        "Polar",
        50,
        'F',
        new Address(
            "2844 Gaslight Ln S",
            "Mobile",
            "AL",
            "36695"
        )
    );

    addressBook.Add(p);
    addressBook.PrintAll();

    var person = addressBook.SearchFor("Gothard");
    if (person is not null)
    {
        person.Print();
    }
}
catch (OutOfBoundsAddressException ex)
{
    Console.WriteLine(ex);
}
catch (AddressBookException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
