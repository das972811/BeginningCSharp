using Battleship.Models;

namespace Battleship;

class Level
{
    private readonly Player _player1;
    private readonly Player _player2;
    private bool _roundIsOver = false;

    public Level(Player player1, Player player2)
    {
        (_player1, _player2) = (player1, player2);
    }

    public void Play()
    {
        // _player1.GetUserPoint();
        // var test = _player1.InputtedPoint;

        // Console.WriteLine(test?.X + " " + test?.Y);

        while (!_roundIsOver)
        {
            Console.WriteLine("Player 1:");
            _player1.GetUserPoint();
            _player1.Attack(_player1.InputtedPoint, _player2.Battleships);

            Console.WriteLine("Player 2:");
            _player2.GetUserPoint();
            _player2.Attack(_player2.InputtedPoint, _player1.Battleships);

            if (_player1.HasLose() || _player2.HasLose())
            {
                _roundIsOver = true;;
            }
        }
    }
}