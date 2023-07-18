using Battleship.Models;

namespace Battleship;

class Level
{
    private readonly BasicPlayer _player1;
    private readonly BasicPlayer _player2;
    private readonly Map _map;
    private bool _roundIsOver = false;

    public Level(BasicPlayer player1, BasicPlayer player2, Map map)
    {
        (_player1, _player2, _map) = (player1, player2, map);
    }

    public void Play()
    {
        while (!_roundIsOver)
        {
            Console.WriteLine("Player 1:");
            _player1.GetPoint();
            _player1.Attack(_player1.InputtedPoint, _player2.Battleships);

            Console.WriteLine("Player 2:");
            _player2.GetPoint();
            _player2.Attack(_player2.InputtedPoint, _player1.Battleships);

            _player1.ViewPreviousAttacks();

            if (_player1.HasLose() && _player2.HasLose())
            {
                Console.WriteLine("It a draw");
                _roundIsOver = true;
            }
            else if (_player1.HasLose())
            {
                Console.WriteLine("Player 2 won this round!");
                Console.WriteLine("Player 1 has lose.");
                _roundIsOver = true;
            }
            else if (_player2.HasLose())
            {
                Console.WriteLine("Player 1 won this round!");
                Console.WriteLine("Player 2 has lose");
                _roundIsOver = true;;
            }
        }
    }
}