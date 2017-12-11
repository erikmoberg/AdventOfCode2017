using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day11Star1 : IResultGenerator<int, string>
    {
        public int Get(string input)
        {
            var grouped = input.Split(',')
                .Select(x => x == "n" ? 0 : x == "ne" ? 1 : x == "se" ? 2 : x == "s" ? 3 : x == "sw" ? 4 : 5)
                .GroupBy(x => x)
                .ToDictionary(x => x.Key, z => z.Count());

            for (var i = 0; i < 6; i++)
            {
                if (!grouped.ContainsKey(i))
                {
                    grouped.Add(i, 0);
                }
            }

            var list = grouped.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            for (var i = 0; i < list.Count(); i++)
            {
                while (list[i] > 0 && list[(i + 2) % list.Count] > 0)
                {
                    list[i]--;
                    list[(i + 1) % list.Count]++;
                    list[(i + 2) % list.Count]--;
                }
                
                while (list[i] > 0 && list[(i + 3) % list.Count] > 0)
                {
                    list[i]--;
                    list[(i + 3) % list.Count]--;
                }
            }

            return list.Select(x => x.Value).Sum();
        }
    }
}