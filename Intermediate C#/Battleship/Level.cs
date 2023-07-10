using Battleship.Models;

namespace Battleship;

class Level
{
    private readonly Player _player1;
    private readonly Player _player2;

    public Level(Player player1, Player player2)
    {
        (_player1, _player2) = (player1, player2);
    }

    public void Play()
    {
        Point point = _player1.GetUserPoint();
        // while (_player1.HasLose() || _player2.HasLose())
        // {
        // }
    }
}