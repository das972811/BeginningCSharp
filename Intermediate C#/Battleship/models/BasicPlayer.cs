namespace Battleship.Models;

class BasicPlayer : IPlayer
{
    private readonly History _history = new History();

    public IBattleship[] Battleships { get; }
    public Point InputtedPoint { get; protected set; } = new Point();

    public BasicPlayer(IBattleship[] battleships) => Battleships = battleships;

    public bool Attack(Point point, IBattleship[] battleships)
    {
        bool hasHitBattleship = false;

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
                    hasHitBattleship = true;
                    battleship.DecreaseHealth();

                    RecordAttack(battleship, hasHitBattleship, point);
                    
                    Console.WriteLine("Hit a " + battleship);
                    return hasHitBattleship;
                }
            }
        }

        RecordAttack(null, hasHitBattleship, point);
        Console.WriteLine("Missed");

        return hasHitBattleship;
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

    public virtual void GetPoint()
    {
        int x, y;

        Console.WriteLine("Please enter a coordinate position");
        Console.Write("X value: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y value: ");
        y = Convert.ToInt32(Console.ReadLine());
    

        InputtedPoint = new Point(x, y);
    }

    public virtual void ViewPreviousAttacks() => _history.ViewEntries();

    protected virtual void RecordAttack(IBattleship? battleship, bool hasDoneDamage, Point attackPoint)
    {
        var entry = new Entry(battleship, hasDoneDamage, attackPoint);
        _history.Add(entry);
    }
}