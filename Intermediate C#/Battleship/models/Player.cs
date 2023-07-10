namespace Battleship.Models;

class Player
{
    public IBattleship[] Battleships { get; }
    public Player(IBattleship[] battleships) => Battleships = battleships;

    public bool Attack(Point point, IBattleship[] battleships)
    {
        foreach (IBattleship battleship in battleships)
        {
            foreach (Point _point in  battleship.Position.Location)
            {
                if (point.Equals(_point))
                {
                    Console.WriteLine("Hit a " + battleship);
                    battleship.DecreaseHealth();
                    return true;
                }
            }
        }

        Console.WriteLine("Missed");
        return false;
    }
}