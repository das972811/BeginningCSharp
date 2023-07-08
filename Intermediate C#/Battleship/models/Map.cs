namespace Battleship.Models;

class Map
{
    public readonly int Width;
    public readonly int Height;

    public Map(int width, int height) => (Width, Height) = (width, height);
}