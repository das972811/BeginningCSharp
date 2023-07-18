using Battleship.Models;

namespace Battleship;

enum Direction
{
    North,
    East,
    South,
    West
}

class SetLocation
{
    private readonly int _numOfBattleships;
    public List<IBattleship> Battleships { get; } = new ();

    public SetLocation(int numOfBattleships) => _numOfBattleships = numOfBattleships;

    public void AddBattleship(string desireBattleship)
    {
        // IBattleship battleship;
        EBattlship eBattlship;
        if(Enum.TryParse(desireBattleship, out eBattlship))
        {
            switch (eBattlship)
            {
                case EBattlship.BasicBattleship:
                {
                    // battleship = new BasicBattleship();
                    break;
                }
                case EBattlship.Carrier:
                {
                    break;
                }
                case EBattlship.Destroyer:
                {
                    break;
                }
                case EBattlship.PatrolBoat:
                {
                    break;
                }
                case EBattlship.Submarine:
                {
                    break;
                }
                default: break;
            }
        }
    }

    private Position GenerateLocation(IBattleship battleship)
    {
        int size = battleship.Size;
        Point[] location = new Point[size];

        for (int i = 0; i < size; i++)
        {
            location[i] = new Point(1 , 2);
        }

        return new Position(location);
    }
}