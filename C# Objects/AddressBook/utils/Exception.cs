namespace AddressBook.Utils
{
    class AddressBookException : Exception
    {
        public AddressBookException()
        {
        }

        public AddressBookException(string message) : base(message)
        {
        }
    }

    class OutOfBoundsAddressException : AddressBookException
    {
        public OutOfBoundsAddressException()
        {
        }

        public OutOfBoundsAddressException(string message) : base(message)
        {
        }
    }
}