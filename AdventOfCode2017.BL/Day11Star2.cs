using System;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL
{
    public class Day11Star2 : IResultGenerator<int, string>
    {
        object lockObject = new object();
        public int Get(string input)
        {
            var maxDistance = int.MinValue;
            var allParts = input.Split(',');
            var numberParts = allParts.Select(x => x == "n" ? 0 : x == "ne" ? 1 : x == "se" ? 2 : x == "s" ? 3 : x == "sw" ? 4 : 5).ToArray();
            Parallel.For(1, numberParts.Count() + 1, (i) =>
            {
                var distance = this.GetDistance(numberParts.Take(i).ToArray());
                lock(lockObject)
                {
                    maxDistance = Math.Max(maxDistance, distance);
                }
            });

            return maxDistance;
        }

        private int GetDistance(int[] input)
        {
            const int sides = 6;
            var grouped = input.GroupBy(x => x).ToDictionary(x => x.Key, z => z.Count());

            for (var i = 0; i < sides; i++)
            {
                if (!grouped.ContainsKey(i))
                {
                    grouped.Add(i, 0);
                }
            }

            for (var i = 0; i < sides; i++)
            {
                while (grouped[i] > 0 && grouped[(i + 2) % sides] > 0)
                {
                    grouped[i]--;
                    grouped[(i + 1) % sides]++;
                    grouped[(i + 2) % sides]--;
                }

                while (grouped[i] > 0 && grouped[(i + 3) % sides] > 0)
                {
                    grouped[i]--;
                    grouped[(i + 3) % sides]--;
                }
            }

            return grouped.Sum(x => x.Value);
        }
    }
}