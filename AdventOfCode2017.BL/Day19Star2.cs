using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day19Star2 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var x = input.First().IndexOf("|");
            var y = 0;
            var direction = 2;
            for(var steps = 0; ; steps++)
            {
                var current = input[y][x];
                if (current == '+')
                {
                    // change direction
                    switch (direction)
                    {
                        case 0:
                        case 2:
                            direction = input[y][x + 1].ToString() != " " ? 1 : 3;
                            break;
                        case 1:
                        case 3:
                            direction = input[y + 1][x].ToString() != " " ? 2 : 0;
                            break;
                    }
                }

                if (current == ' ')
                {
                    return steps;
                }

                x += direction == 1 ? 1 : direction == 3 ? -1 : 0;
                y += direction == 0 ? -1 : direction == 2 ? 1 : 0;
            }
        }
    }
}