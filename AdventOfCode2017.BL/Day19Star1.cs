using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day19Star1 : IResultGenerator<string, string[]>
    {
        public string Get(string[] input)
        {
            var x = input.First().IndexOf("|");
            var y = 0;
            var direction = 2;
            var letters = string.Empty;
            while (true)
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
                    return letters;
                }

                if (char.IsLetter(current))
                {
                    letters += current;
                }

                x += direction == 1 ? 1 : direction == 3 ? -1 : 0;
                y += direction == 0 ? -1 : direction == 2 ? 1 : 0;
            }
        }
    }
}