namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map (int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public bool OnMap(Point point)
        {
            // bool outOfBounds = point.X < 0 || point.X >= Width ||
            //                     point.Y < 0 || point.Y >= Height;

            // inBounds = !outOfBounds;
            // return inBounds;
            return point.X >= 0 && point.X <= Width &&
                    point.Y >= 0 && point.Y <= Height;
        }
    }
}