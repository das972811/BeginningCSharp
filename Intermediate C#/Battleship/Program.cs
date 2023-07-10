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
            // new BasicBattleShip
            // (
            //     new Position
            //     (
            //         new Point[]
            //         {
            //             new Point(1, 1),
            //             new Point(1, 2),
            //             new Point(1, 3),
            //             new Point(1, 4)
            //         }
            //     )
            // )
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
            // new BasicBattleShip
            // (
            //     new Position
            //     (
            //         new Point[]
            //         {
            //             new Point(6, 2),
            //             new Point(6, 3),
            //             new Point(6, 4),
            //             new Point(6, 5),
            //         }
            //     )
            // )
        };

        Player diego = new Player(DiegoBattleships);
        Player ignacio = new Player(IgnacioBattleships);

        Level level = new Level(diego, ignacio);
        level.Play();
    }
}