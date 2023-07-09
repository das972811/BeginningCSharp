namespace Battleship.Models;

interface IMappable
{
    Position Position { get; }
}

interface IBattleship
{
    bool IsNeutralized { get; }
    public void DecreaseHealth(int factor);
}