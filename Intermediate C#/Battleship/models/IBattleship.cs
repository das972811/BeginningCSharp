namespace Battleship.Models;

interface IMappable
{
    Position Position { get; }
}

interface IBattleship : IMappable
{
    bool IsNeutralized { get; }
    public void DecreaseHealth();
}