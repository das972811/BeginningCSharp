namespace AddressBook.Model
{
    class AddressCatalog
    {
        public Person[] People { get; }

        public AddressCatalog(Person[] people) => People = people;
    }
}