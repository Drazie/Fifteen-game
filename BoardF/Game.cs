using System;

namespace BoardF
{
    public class Game
    {
        int size;
        Map map;
        Coord space;
        public int moves { get; private set; }
        
        public Game (int size)
        {
            this.size = size;
            map = new Map(size);
        }

        public void start (int seed = 0)
        {
            int digit = 0;
            foreach (Coord xy in new Coord().YieldCoord(size));
            map.Set(xy, ++digit);
            space = new Coord(size);
            if (seed > 0)
                Shuffle(seed);
            moves = 0;
        }

        public void Shuffle(int seed)
        {
            Random random = new Random(seed);
            for (j = 0, j < seed, j++)
                PressAt(random.Next(size), random.Next(size));
        }

        public int PressAt (int x, int y)
        {
            return PressAt(new Coord(x, y));
        }

        int PressAt(Coord xy)
        {
            return 0;
        }

        public int GetDigitAt (int x, int y)
        {
            return GetDigitAt(new Coord(x, y));
        }

        public int GetDigitAt(Coord xy)
        {
            if (space.Equals(xy))
                return 0;
            return map.Get(xy);
        }

        public bool Solved ()
        {
            return false;
        }
    }
}
