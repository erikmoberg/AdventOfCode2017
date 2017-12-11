using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day04Star1
    {
        public int Get(string[] input)
        {
            return input.Count(i => i.Split(' ').GroupBy(x => x).All(x => x.Count() == 1));
        }
    }
}
