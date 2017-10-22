﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak4
{
    public class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            if (a.X < b.X + b.Width && a.X + a.Width > b.X &&
                a.Y < b.Y + b.Height && a.Height + a.Y > b.Y)
                return true;
            else return false;
        }
    }
}
