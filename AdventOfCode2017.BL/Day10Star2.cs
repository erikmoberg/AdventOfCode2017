using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day10Star2 : IResultGenerator<string, string>
    {
        public string Get(string input)
        {
            var lengths = input.Select(c => (int)c).Concat(new[] { 17, 31, 73, 47, 23 }).ToArray();
            var skipSize = 0;
            var position = 0;
            var list = Enumerable.Range(0, 256).ToArray();
            for (var rounds = 0; rounds < 64; rounds++)
            {
                foreach (var length in lengths)
                {
                    for (var j = 0; j < length / 2; j++)
                    {
                        var index1 = (position + j) % list.Count();
                        var index2 = (position + (length - 1 - j)) % list.Count();
                        var temp = list[index1];
                        list[index1] = list[index2];
                        list[index2] = temp;
                    }

                    position += length + skipSize;
                    skipSize++;
                }
            }

            var dense = new List<int>();
            for (var i = 0; i < 256; i += 16)
            {
                dense.Add(list.Skip(i).Take(16).Aggregate((aggregated, number) => aggregated ^ number));
            }

            return string.Join(string.Empty, dense.Select(x => x.ToString("x2")));
        }
    }
}