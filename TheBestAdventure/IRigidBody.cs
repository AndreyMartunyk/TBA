using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestAdventure
{
    interface IRigidBody
    {
        Point2D start { get;  set; }
        Point2D end { get;  set; }

        Point2D[] GetBoxCollider()
        {
            return new Point2D(1, 1);
        }
    }
}
