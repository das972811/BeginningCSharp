namespace Battleship.Models;

class PatrolBoat : Battleship
{
    public override int Size { get; } = 2;
    public override int Health { get; protected set; } = 2;

    public PatrolBoat(Position position) : base(position) { }
}