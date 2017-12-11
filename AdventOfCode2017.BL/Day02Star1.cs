using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL
{
    public class Day02Star1
    {
        public int Get(string input)
        {
            var lines = input.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var totalDifference = 0;
            foreach(var l in lines)
            {
                var numbers = l.Split(new[] { "\t" }, StringSplitOptions.RemoveEmptyEntries).Select(y => Convert.ToInt32(y)).ToArray();
                totalDifference += numbers.Max() - numbers.Min();
            }

            return totalDifference;
        }
    }
}
