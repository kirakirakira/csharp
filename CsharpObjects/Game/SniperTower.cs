namespace TreehouseDefense
{
    class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 0.99;

        public SniperTower(MapLocation location) : base(location)
        {

        }
    }
}