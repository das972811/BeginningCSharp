namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = .90;

        public SniperTower (MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}