namespace Battleship.Models;

class Entry
{
    public IBattleship? Battleship { get; }
    public bool HasDoneDamage { get; }
    public Point AttackPoint { get; }

    public Entry(IBattleship? battleship, bool hasDoneDamage, Point attackPoint)
    {
        Battleship = battleship;
        HasDoneDamage = hasDoneDamage;
        AttackPoint = attackPoint;
    }

    public override string ToString()
    {
        if (Battleship == null)
        {
            return "Attacked at coordinate " + AttackPoint + " - " + HasDoneDamage;
        }
        return "Attacked " + Battleship + " at coordinate " +
            AttackPoint + " - " + HasDoneDamage;
    }
}