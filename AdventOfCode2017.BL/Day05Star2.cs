using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day05Star2
    {
        public int Get(int[] input)
        {
            var position = 0;
            for (var i = 0; ;i++)
            {
                var lastPosition = position;
                position += input[position];
                if(position < 0 || position >= input.Length)
                {
                    return i + 1;
                }

                input[lastPosition] += (input[lastPosition] >= 3 ? -1 : 1);
            }
        }
    }
}
