namespace Battleship.Models
{
    abstract class Battleship : IBattleship
    {
        private readonly Position _position;

        public abstract int Size { get; }
        public abstract int Health { get; protected set; }

        // public bool IsNeutralized { get => Health == 0; }
        public bool IsNeutralized => Health == 0;
        public Position Position { get => _position; }

        public Battleship(Position position)
        {
            _position = position;
        }

        public virtual void DecreaseHealth() => Health--;

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}