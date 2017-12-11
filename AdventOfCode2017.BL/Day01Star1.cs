using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL
{
    public class Day01Star1
    {
        // 240205-20171203-524a9ad5

        public int Get(string input)
        {
            var lastChar = input.ElementAt(0);
            var input2 = (input + input.ElementAt(0)).Skip(1).ToArray();
            var value = 0;
            foreach (var s in input2)
            {
                if (lastChar == s)
                {
                    value += Convert.ToInt32(s - 48);
                }

                lastChar = s;
            }

            return value;
        }
    }
}
