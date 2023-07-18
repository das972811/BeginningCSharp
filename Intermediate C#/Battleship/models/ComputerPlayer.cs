namespace Battleship.Models;

class ComputerPlayer : BasicPlayer 
{
    public ComputerPlayer(IBattleship[] battleships) : base(battleships)
    {
    }

    public override void GetPoint()
    {
        // int x, y;
        // x = y = 2;

        // InputtedPoint = new Point(x, y);

        throw new NotImplementedException();
    }
}