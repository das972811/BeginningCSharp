using Battleship.Models;

namespace Battleship;

class Program
{
    static void Main(string[] args)
    {
        Point diego = new Point(2, 2);
        Point ignacio = new Point(2, 2);
        Console.WriteLine(diego.Equals(ignacio));
    }
}