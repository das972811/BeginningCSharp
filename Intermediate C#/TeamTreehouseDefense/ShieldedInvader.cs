namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        // private static Random _random = new Random();
        public override int Health { get; protected set; } = 1;

        public ShieldedInvader(Path path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if (Random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader but it sustained no damage");
            }
        }
    }
}