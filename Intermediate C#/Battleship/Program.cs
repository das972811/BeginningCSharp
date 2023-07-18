using Battleship.Models;

namespace Battleship;

class Program
{
    static void Main(string[] args)
    {
        Map map = new Map(10, 10);
        IBattleship[] DiegoBattleships;
        IBattleship[] IgnacioBattleships;

        DiegoBattleships = new IBattleship[]
        {
            new Destroyer
            (
                new Position
                (
                    new Point[]
                    {
                        new Point(2, 2),
                        new Point(2, 3),
                        new Point(2, 4)
                    }
                )
            )
        };

        IgnacioBattleships = new IBattleship[]
        {
            new PatrolBoat
            (
                new Position
                (
                    new Point[]
                    {
                        new Point(4, 5),
                        new Point(4, 6)
                    }
                )
            )
        };

        // var diego = new BasicPlayer(DiegoBattleships);
        // var ignacio = new BasicPlayer(IgnacioBattleships);

        // Level level = new Level(diego, ignacio, map);
        // level.Play();

        var test = new SetLocation(5);

        test.AddBattleship("BasicBattleship");
    }
}