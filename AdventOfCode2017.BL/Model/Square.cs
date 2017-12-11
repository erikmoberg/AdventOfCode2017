namespace AdventOfCode2017.BL.Model
{
    internal class Square
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Number { get; set; }

        public override string ToString()
        {
            return $"{this.Number}: {this.X}/{this.Y}"; 
        }
    }
}