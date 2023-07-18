namespace Battleship.Models
{
    class BasicBattleship : Battleship
    {
        public override int Size { get; } = 4;
        public override int Health { get; protected set; } = 4;

        public BasicBattleship(Position position) : base(position)
        {
        }
    }
}