using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day12Star1 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var list = new List<int> { 0 };
            var input2 = input.Select(x => x.Replace(" <-> ", ",").Split(',').Select(y => int.Parse(y)).ToArray()).ToList();
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

            return list.Count();
        }
    }
}