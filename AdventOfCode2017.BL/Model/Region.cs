using System.Collections.Generic;

namespace AdventOfCode2017.BL.Model
{
    internal class Region
    {
        public Region()
        {
            this.Coordinates = new List<Coordinate>();
        }

        public List<Coordinate> Coordinates { get; set; }
    }
}