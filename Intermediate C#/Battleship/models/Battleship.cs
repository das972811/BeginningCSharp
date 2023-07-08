namespace Battleship.Models
{
    abstract class Battleship
    {
        private readonly Position _position;

        public abstract int Health { get; protected set; }
        public abstract int Size { get; }

        public Battleship(Position position)
        {
            _position = position;
        }

        public virtual void DecreaseHealth(int factor) => Health -= factor;
    }
}