namespace Battleship.Models;

class Position
{
    private readonly Point[] _points;

    public Point[] Location { get => _points; }

    public Position(Point[] points)
    {
        _points = points;
    }
}