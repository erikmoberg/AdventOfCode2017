using System;

namespace AdventOfCode2017.BL.Model
{
    public class SimpleVector3
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public SimpleVector3(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int Length => Math.Abs(this.X) + Math.Abs(this.Y) + Math.Abs(this.Z);

        public static bool operator ==(SimpleVector3 v1, SimpleVector3 v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
        }

        public static bool operator !=(SimpleVector3 v1, SimpleVector3 v2)
        {
            return v1.X != v2.X || v1.Y != v2.Y || v1.Z != v2.Z;
        }

        public override bool Equals(object obj)
        {
            return this == (SimpleVector3)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}