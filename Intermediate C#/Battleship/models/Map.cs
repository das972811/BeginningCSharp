namespace Battleship.Models;

class Map
{
    public readonly int Width;
    public readonly int Height;

    public Map(int width, int height) => (Width, Height) = (width, height);

    public bool OnMap(Point point) => point.X >= 0 && point.X <= Width &&
                                        point.Y >= 0 && point.Y <= Height;
}