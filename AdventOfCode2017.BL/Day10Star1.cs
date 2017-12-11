using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day10Star1 : IResultGenerator<int, string, int>
    {
        public int Get(string input, int numberOfElements)
        {
            var lengths = input.Split(',').Select(x => int.Parse(x)).ToArray();
            var skipSize = 0;
            var position = 0;
            var list = Enumerable.Range(0, numberOfElements).ToArray();
            foreach (var length in lengths)
            {
                for (var j = 0; j < length / 2; j++)
                {
                    var index1 = (position + j) % list.Count();
                    var index2 = (position + (length - 1 - j)) % list.Count();
                    var temp = list[index1];
                    list[index1] = list[index2];
                    list[index2] = temp;
                }

                position += length + skipSize;
                skipSize++;
            }

            return list[0] * list[1];
        }
    }
}