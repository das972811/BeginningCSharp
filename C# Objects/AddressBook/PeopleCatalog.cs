using AddressBook.Model;

class PeopleCatalog
{
    public static Person[] People =
    {
        new Person
        (
            "Igancio", "Salas Polar", 21, 'M',
            new Address
            (
                "2844 Gaslight Ln S", "Mobile", "AL", "36695"
            )
        ),
        new Person
        (
            "Lauren", "Gothard", 20, 'F',
            new Address
            (
                "2122 Madison Rd W ", "Mobile", "AL", "36604"
            )
        ),
        new Person
        (
            "Riley", "Sears", 23, 'M',
            new Address
            (
                "2378 Golf Ct Dr ", "Fairhope", "AL", "36502"
            )
        ),
        new Person
        (
            "Logan", "Lewis", 20, 'M',
            new Address
            (
                "1123 Manner S", "Thor", "AL", "23604"
            )
        ),
        new Person
        (
            "Kendall", "Thomas", 20, 'F',
            new Address
            (
                "8967 Scenic Dr E", "Auburn", "AL", "98354"
            )
        ),
    };
}