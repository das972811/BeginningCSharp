namespace Battleship.Models
{
    class BasicBattleShip : Battleship
    {
        public override int Size { get; } = 4;
        public override int Health { get; protected set; } = 4;

        public BasicBattleShip(Position position) : base(position)
        {
        }
    }
}