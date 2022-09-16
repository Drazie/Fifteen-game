﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BoardF
{
    struct Coord
    {
        public int x; 
        public int y;

        public Coord (int size)
        {
            x = size - 1;
            y = size - 1;
        }

        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool OnBoard(int size)
        {
            if (x < 0 || x > size -1) return false;
            if (y < 0 || y > size -1) return false;
            return true;
        }

        public IEnumerable<Coord> YieldCoord(int size)
        {
            for (y = 0; y < size; y++)
                for (x = 0; x < size; x++)
                    yield return this;
        }

        public Coord Add(int sx, int sy)
        {
            return new Coord(x + sx, y + sy);
        }
    }
}
