using AdventOfCode2017.BL.Model;
using System.Collections.Generic;

namespace AdventOfCode2017.BL
{
    public class Day22Star2 : IResultGenerator<int, string[], int>
    {
        public int Get(string[] input, int iterations)
        {
            var nodes = new Dictionary<double, NodeState>();
            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    nodes.Add(i + j / 1000d, input[j][i] == '#' ? NodeState.Infected : NodeState.Clean);
                }
            }

            var x = input.Length / 2;
            var y = input.Length / 2;
            var direction = 0;
            var infectedTimes = 0;
            for (var i = 0; i < iterations; i++)
            {
                var coords = x + y / 1000d;
                var currentState = NodeState.Clean;
                var hasValue = nodes.TryGetValue(coords, out currentState);
                var newState = (NodeState)((((int)currentState) + 1) % 4);

                if (hasValue)
                {
                    nodes[coords] = newState;
                }
                else
                {
                    nodes.Add(coords, newState);
                }

                direction = (direction + 
                            (currentState == NodeState.Clean ? 3 :
                             currentState == NodeState.Weakened ? 0 :
                             currentState == NodeState.Infected ? 1 :
                             2)) % 4;

                x += direction == 1 ? 1 : direction == 3 ? -1 : 0;
                y += direction == 2 ? 1 : direction == 0 ? -1 : 0;

                if (newState == NodeState.Infected)
                {
                    infectedTimes++;
                }
            }

            return infectedTimes;
        }
    }
}