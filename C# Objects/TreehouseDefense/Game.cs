namespace TreehouseDefense
{
    class Game
    {
        public static void Run()
        {
            Map map = new Map(8, 5);

            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map),
                    }
                );

                Invader[] invaders = new Invader[] {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers = new Tower[] {
                    new Tower(new MapLocation(1, 3, map)),
                    new Tower(new MapLocation(3, 3, map)),
                    new Tower(new MapLocation(5, 3, map)),
                };

                Level level = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level.Play();


                Console.WriteLine("Player " + (playerWon ? "won" : "lost"));

                // Invader invader = new Invader(path);
                // MapLocation location = new MapLocation(0, 2, map);
                // location = invader.Location;

                // MapLocation? location = path.GetLocationAt(8);
                // if (location != null)
                // {
                //     Console.WriteLine(location?.X + "," + location?.Y);
                // }
            }
            catch(OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TreehouseDefenseException)
            {
                Console.WriteLine("Unhandled TreehouseDefenseException");
            }
            catch(Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }
        }
    }
}