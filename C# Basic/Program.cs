static string? Ask(string question)
{
    Console.Write(question + " ");
    return Console.ReadLine();
}

Console.WriteLine("Welcome to the cat food store!");
string? entry = Ask("How many cans are you ordering?");
Console.WriteLine($"You entered {entry} cans");