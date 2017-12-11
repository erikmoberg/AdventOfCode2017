using System;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day02Star2
    {
        public int Get(string input)
        {
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var totalDifference = 0;
            foreach(var l in lines)
            {
                var numbers = l.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries).Select(y => Convert.ToInt32(y)).ToArray();
                var cartesian = from n1 in numbers
                                from n2 in numbers
                                select new
                                {
                                    n1,
                                    n2
                                };
                var pair = cartesian.FirstOrDefault(x => x.n1 % x.n2 == 0 && x.n1 != x.n2);
                totalDifference += pair.n1 / pair.n2;
            }

            return totalDifference;
        }
    }
}
