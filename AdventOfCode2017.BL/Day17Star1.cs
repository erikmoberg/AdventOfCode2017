using System.Collections.Generic;

namespace AdventOfCode2017.BL
{
    public class Day17Star1 : IResultGenerator<int, int>
    {
        public int Get(int input)
        {
            var position = 0;
            var list = new List<int> { 0 };
            for (var i = 0; i < 2017; i++)
            {
                var insertAt = (position + input) % list.Count + 1;
                list.Insert(insertAt, i + 1);
                position = insertAt;
            }

            return list[(position + 1) % list.Count];
        }
    }
}