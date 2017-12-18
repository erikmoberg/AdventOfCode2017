using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day13Star2 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var list1 = input.Select(x => x.Split(new[] { ": " }, StringSplitOptions.None)).ToArray();

            var listWithGaps = list1.Select(x => new
            {
                Index = int.Parse(x[0]),
                Depth = int.Parse(x[1])
            }).ToArray();

            var list = new List<int>();
            for (var i = 0; i <= listWithGaps.Max(x => x.Index); i++)
            {
                list.Add(listWithGaps.FirstOrDefault(x => x.Index == i)?.Depth ?? -1);
            }

            for (var piko = 0; ; piko++)
            {
                var success = true;
                for (var i = 0; i < list.Count(); i++)
                {
                    if (list[i] != -1 && (piko + i) % (list[i] * 2 - 2) == 0)
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    return piko;
                }
            }
        }
    }
}