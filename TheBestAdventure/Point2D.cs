using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestAdventure
{
    class Point2D : IComparable
    {
        public int X
        {
            get
            {
                return _x;
            }
            private set
            {
                if (value < 0)
                {
                    throw new LessThenZeroPointException();
                }
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            private set
            {
                if (value < 0)
                {
                    throw new LessThenZeroPointException();
                }
            }
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point2D(Point2D p)
        {
            _x = p._x;
            _y = p._y;
        }

        public int CompareTo(object obj)
        {
            int res = 1;

            Point2D p = (Point2D)obj;

            if (IsEqual(p))
            {
                res = 0;
            }
            else if ((p.X + p.Y) < (X + Y))
            {
                res = -1;
            }

            return res;
        }

        public bool IsEqual(Point2D p)
        {
            return (p.X == X) && (p.Y == Y);
        }

        private int _x;
        private int _y;

    }
}
