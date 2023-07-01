namespace AddressBook.Model
{
    public class Address
    {
        public string MailingAddress { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string PostalCode { get; private set; }

        public Address(string mailingAddress, string city, string state, string postalCode)
        {
            MailingAddress = mailingAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public void UpdateMailingAddress(string mailingAddress) => MailingAddress = mailingAddress;
        public void UpdateCity(string city) => City = city;
        public void UpdateState(string state) => State = state;
        public void UpdatePostalCode(string postalCode) => PostalCode = postalCode;

        public void Print()
        {
            Console.WriteLine($"{MailingAddress}");
            Console.WriteLine($"{City}, {State} {PostalCode}");
        }
    }
}