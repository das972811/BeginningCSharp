namespace Battleship.Models
{
    abstract class Battleship : IBattleship
    {
        private readonly Guid _id = Guid.NewGuid();

        private readonly Position _position;

        public Guid ID => _id;
        public virtual int Size { get; }
        public abstract int Health { get; protected set; }

        // public bool IsNeutralized { get => Health == 0; }
        public bool IsNeutralized => Health == 0;
        public Position Position { get => _position; }

        public Battleship(Position position)
        {
            _position = position;
        }

        public virtual void DecreaseHealth() => Health--;

        public override bool Equals(object? obj)
        {
            if (obj is null || obj is not IBattleship)
            {
                return false;
            }

            IBattleship? that = (IBattleship?) obj;
            
            return this.ID == that?.ID;
        }

        public override int GetHashCode()
        {
            return Size.GetHashCode() * 31 + Health.GetHashCode();
        }

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}