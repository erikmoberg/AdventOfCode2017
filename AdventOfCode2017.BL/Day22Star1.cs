using System.Collections.Generic;

namespace AdventOfCode2017.BL
{
    public class Day22Star1 : IResultGenerator<int, string[], int>
    {
        public int Get(string[] input, int iterations)
        {
            var nodes = new Dictionary<string, bool>();
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    nodes.Add($"{i};{j}", input[j][i] == '#');
                }
            }

            var x = input.Length / 2;
            var y = input.Length / 2;
            var direction = 0;
            var infectedTimes = 0;
            for (var i = 0; i < iterations; i++)
            {
                var coords = $"{x};{y}";
                if (!nodes.ContainsKey(coords))
                {
                    nodes.Add(coords, false);
                }

                var turnDirection = nodes[coords] ? 1 : 3;
                direction = (direction + turnDirection) % 4;

                nodes[coords] = !nodes[coords];
                if (nodes[coords])
                {
                    infectedTimes++;
                }

                x += direction == 1 ? 1 : direction == 3 ? -1 : 0;
                y += direction == 2 ? 1 : direction == 0 ? -1 : 0;
            }

            return infectedTimes;
        }
    }
}