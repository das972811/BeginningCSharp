namespace AddressBook.Model
{
    class AddressCatalog
    {
        public Person[] People { get; private set; }

        public AddressCatalog(Person[] people) => People = people;

        public Person? SearchFor(string lastName) => Array.Find(People, person => person.LastName.Equals(lastName));

        public void Add(Person person) => People = People.Append(person).ToArray();

        public void Print(Person person)
        {
            Person? _person = SearchFor(person.LastName);
            if (_person is null)
            {
                return;
            }
            Console.WriteLine("Found the following:");
            _person.Print();
        }

        public void PrintAll()
        {
            foreach (Person _person in People)
            {
                _person.Print();
                Console.WriteLine();
            }
        }
    }
}