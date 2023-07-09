using Battleship.Models;

namespace Battleship;

class Program
{
    static void Main(string[] args)
    {
        Map map = new Map(10, 10);

        BasicBattleShip battleship = new BasicBattleShip
        (
            new Position
            (
                new Point[]
                {
                    new Point(1, 1),
                    new Point(1, 2),
                    new Point(1, 3),
                    new Point(1, 4)
                }
            )
        );

        BasicBattleShip battleShip2 = new BasicBattleShip
        (
            new Position
            (
                new Point[]
                {
                    new Point(2, 2),
                    new Point(2, 3)
                }
            )
        );

        IBattleship[] battleships = {battleship};
        IBattleship[] igancioBattleships = {battleShip2};

        Player player = new Player(battleships);
        player.Attack(new Point(2, 2), igancioBattleships);
    }
}