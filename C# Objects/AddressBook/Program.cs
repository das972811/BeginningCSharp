using AddressBook.Model;
using AddressBook.Utils;

try
{
    AddressCatalog addressBook = new AddressCatalog(PeopleCatalog.People);
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
