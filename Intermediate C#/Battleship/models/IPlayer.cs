namespace Battleship.Models;

interface IPlayer
{
    IBattleship[] Battleships { get; }
    Point InputtedPoint { get; }
    bool Attack(Point point, IBattleship[] battleships);
    bool HasLose();
    void GetPoint();
}