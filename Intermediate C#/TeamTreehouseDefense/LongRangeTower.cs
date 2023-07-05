namespace TreehouseDefense
{
    class LongRangeTower : Tower
    {
        protected override int Range { get; } = 1;

        public LongRangeTower (MapLocation mapLocation) : base(mapLocation)
        {
        }
    }
}