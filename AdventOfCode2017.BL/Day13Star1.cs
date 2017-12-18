using AdventOfCode2017.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day13Star1 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var listWithGaps = input.Select(x => x.Split(new[] { ": " }, StringSplitOptions.None))
            .Select(x => new FirewallEntry
            {
                Index = int.Parse(x[0]),
                Depth = int.Parse(x[1]),
                Position = 0,
                Direction = 1
            })
            .ToArray();

            var list = Enumerable.Range(0, listWithGaps.Max(x => x.Index + 1))
                .Select(x => listWithGaps.FirstOrDefault(y => y.Index == x))
                .ToArray();

            var score = 0;
            for (var i = 0; i < list.Length; i++)
            {
                if (list[i] != null)
                {
                    score += list[i].Position == 0 ? list[i].Depth * i : 0;
                }

                foreach (var entry in list)
                {
                    if (entry == null)
                    {
                        continue;
                    }

                    if (entry.Position + entry.Direction < 0 || entry.Position + entry.Direction >= entry.Depth)
                    {
                        entry.Direction *= -1;
                    }

                    entry.Position += entry.Direction;
                }
            }

            return score;
        }
    }
}