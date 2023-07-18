using Battleship.Models;

namespace Battleship;

static class Random
{
    private static System.Random _random = new System.Random();

    public static Point GenerateRandomPoint(Map map)
    {
        int randX = _random.Next(0, map.Width);
        int randY = _random.Next(0, map.Height);

        return new Point(randX, randY);
    }
}