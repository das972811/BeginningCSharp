namespace Battleship.Models;

class Destroyer : Battleship
{
    public override int Health { get; protected set; } = 3;
    public override int Size { get; } = 3;

    public Destroyer(Position position) : base(position) { }
}