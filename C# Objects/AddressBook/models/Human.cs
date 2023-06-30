namespace AddressBook.Model
{
    class Human
    {
        private readonly char _gender;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public char Gender { get => _gender; init => _gender = value; }

        public Human(string firstName, string lastName, int age, char gender) =>
            (FirstName, LastName, Age, Gender) = (firstName, lastName, age, gender);

        public void UpdateFirstName(string firstName) => FirstName = firstName;

        public void UpdateLastName(string lastName) => LastName = lastName;

        public void IncreaseAge() => Age ++;

        public void Print()
        {
            Console.WriteLine($"{FirstName} {LastName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
}