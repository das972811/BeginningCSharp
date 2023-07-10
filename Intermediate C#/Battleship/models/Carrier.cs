namespace Battleship.Models;

class Carrier : Battleship
{
    public override int Size => 5;
    public override int Health { get; protected set; } = 5;

    public Carrier(Position position) : base(position) { }
}