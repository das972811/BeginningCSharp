namespace AddressBook.Model
{
    class AddressCatalog
    {
        public Person[] People { get; }

        public AddressCatalog(Person[] people) => People = people;

        public Person? SearchFor(string lastName) => Array.Find(People, person => person.LastName.Equals(lastName));
        
    }
}