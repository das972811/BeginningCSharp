namespace Battleship.Models;

class Entry
{
    public IBattleship? Battleship { get; }
    public bool HasDoneDamage { get; }
    public Point AttackPoint { get; }

    public Entry()
    {
    }
}