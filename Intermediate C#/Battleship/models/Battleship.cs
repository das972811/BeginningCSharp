namespace Battleship.Models
{
    abstract class Battleship
    {
        public abstract int Health { get; protected set; }
        public abstract int Size { get; }

        public Battleship()
        {}

        public virtual void DecreaseHealth(int factor) => Health -= factor;
    }
}