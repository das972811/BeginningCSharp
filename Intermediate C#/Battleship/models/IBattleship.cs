namespace Battleship.Models;

interface IMappable
{
    Position Position { get; }
}

interface IBattleship : IMappable
{
    Guid ID { get; }
    bool IsNeutralized { get; }
    public void DecreaseHealth();
}