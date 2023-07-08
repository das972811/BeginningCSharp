namespace Battleship.Models
{
    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public override bool Equals(object? obj)
        {
            if (obj is null || obj is not Point)
            {
                return false;
            }
            Point? that = (Point?) obj;

            return this.X == that?.X && this.Y == that?.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }
    }
}