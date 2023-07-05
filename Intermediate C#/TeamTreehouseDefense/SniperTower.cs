namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override int Range { get; } = 2;

        protected override double Accuracy { get; } = .90;

        public SniperTower (MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}