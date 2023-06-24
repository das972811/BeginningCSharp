static string? Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

static double Price(int quantity) {
    return quantity * 2;
}

Console.WriteLine("Welcome to the cat food store!");
string? entry = Ask("How many cans are you ordering?");
// Console.WriteLine($"You entered {entry} cans");

int num;
int.TryParse(entry, out num);

double total = (double) Price(num);

Console.WriteLine($"For {num} cans, your total is: ${total}");