using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day12Star2 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var input2 = input.Select(x => x.Replace(" <-> ", ",").Split(',').Select(y => int.Parse(y)).ToArray()).ToList();
            var groups = 0;
            for (; input2.Any(); groups++)
            {
                var list = new List<int> { input2.First().First() };
                var found = true;
                while (found)
                {
                    found = false;
                    for (var j = 0; j < list.Count; j++)
                    {
                        for (var i = input2.Count - 1; i >= 0; i--)
                        {
                            if (input2[i].Any(x => x == list[j]))
                            {
                                list.AddRange(input2[i]);
                                list = list.Distinct().ToList();
                                input2.RemoveAt(i);
                                found = true;
                            }
                        }
                    }
                }
            }

            return groups;
        }
    }
}