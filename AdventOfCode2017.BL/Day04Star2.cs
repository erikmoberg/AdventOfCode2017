using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day04Star2
    {
        public int Get(string[] input)
        {
            return input
                .Count(i => i.Split(' ')
                    .Select(x => string.Join(string.Empty, x.OrderBy(w => w)))
                    .GroupBy(x => x)
                    .All(x => x.Count() == 1));
        }
    }
}
