namespace TreehouseDefense
{
    class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;
        private readonly MapLocation _location;

        private static readonly Random _random = new Random();


        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            // int index = 0;
            
            // while (index < invaders.Length)
            // {
            //     Invader invader  = invaders[index];

            //     index++;
            // }

            // for (int i = 0; i < invaders.Length; i++)
            // {
            //     Invader invader = invaders[i];
            // }

            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at and hit an invader!");

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized invader");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader.");
                    }
                    break;
                }
            }
        }
    }
}