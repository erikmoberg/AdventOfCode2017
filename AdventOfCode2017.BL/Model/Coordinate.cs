namespace AdventOfCode2017.BL.Model
{
    public class Coordinate
    {
        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return this.X + "-" + this.Y;
        }
    }
}