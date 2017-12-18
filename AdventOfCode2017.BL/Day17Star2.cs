namespace AdventOfCode2017.BL
{
    public class Day17Star2 : IResultGenerator<int, int>
    {
        public int Get(int input)
        {
            var limit = 50000000;
            var position = 0;
            var result = 0;
            for (var i = 1; i < limit; i++)
            {
                position = ((position + input) % i) + 1;
                if (position == 1)
                {
                    result = i;
                }
            }

            return result;
        }
    }
}