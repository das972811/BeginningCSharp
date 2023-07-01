namespace AddressBook.Model
{
    class Person : Human
    {
        public Address Address { get; private set; }

        public Person(string firstName, string lastName, int age, char gender, Address address) :
                    base(firstName, lastName, age, gender)
                    => Address = address;
        
        public new void Print()
        {
            base.Print();
            Console.WriteLine();
            Address.Print();
        }
    }
}