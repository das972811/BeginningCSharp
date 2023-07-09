namespace Battleship.Models
{
    abstract class Battleship : IBattleship
    {
        private readonly Position _position;

        public abstract int Health { get; protected set; }
        public abstract int Size { get; }
        public bool IsNeutralized { get => Health <= 0; }
        public Position Position { get => _position; }

        public Battleship(Position position)
        {
            _position = position;
        }

        public virtual void DecreaseHealth(int factor) => Health -= factor;

    }
}