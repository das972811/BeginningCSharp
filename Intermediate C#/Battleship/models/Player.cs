namespace Battleship.Models;

class Player
{
    public IBattleship[] Battleships { get; }
    public Player(IBattleship[] battleships) => Battleships = battleships;

    public bool Attack(Point point, IBattleship[] battleships)
    {
        for (int i = 0; i < battleships.Length; i++)
        {
            IBattleship battleship = battleships[i];

            if (battleship.IsNeutralized)
            {
                continue;
            }

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

    public bool HasLose()
    {
        int sinkingShip = 0;

        foreach (IBattleship battleship in Battleships)
        {
            if (battleship.IsNeutralized)
            {
                sinkingShip++;
            }
        }

        return sinkingShip == Battleships.Length;
    }

    public Point GetUserPoint()
    {
        int x, y;

        Console.WriteLine("Please enter a coordinate position");
        Console.Write("X value: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y value: ");
        y = Convert.ToInt32(Console.ReadLine());
    

        return new Point(x, y);
    }
}