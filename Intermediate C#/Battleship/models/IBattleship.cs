namespace Battleship.Models;

interface IMappable
{
    Position Position { get; }
}

interface IBattleship : IMappable
{
    Guid ID { get; }
    int Size { get; }
    bool IsNeutralized { get; }
    public void DecreaseHealth();
}