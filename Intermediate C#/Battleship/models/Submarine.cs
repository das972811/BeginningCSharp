namespace Battleship.Models;

class Submarine : Battleship
{
    public override int Health { get; protected set; } = 3;
    public override int Size { get; } = 3;

    public Submarine(Position position) : base(position) { }
}