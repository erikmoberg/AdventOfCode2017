using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day06Star2
    {
        public int Get(int[] input)
        {
            this.FindLoop(input);
            return FindLoop(input);
        }

        private int FindLoop(int[] input)
        {
            var seen = new HashSet<string> { string.Join(",", input) };
            while (true)
            {
                var value = input.Max();
                var position = Array.IndexOf(input, value);
                input[position] = 0;
                for (var i = position + 1; value > 0; i++)
                {
                    i %= input.Length;
                    input[i]++;
                    value--;
                }

                var stringified = string.Join(",", input);
                if (seen.Contains(stringified))
                {
                    return seen.Count;
                }

                seen.Add(stringified);
            }
        }
    }
}
