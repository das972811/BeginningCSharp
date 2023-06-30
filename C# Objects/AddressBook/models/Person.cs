namespace AddressBook.Model
{
    public class Person : Human
    {
        public string MailingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }

        public Person() : base()
        {

        }
    }
}