using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL
{
    public class Day01Star2
    {
        public int Get(string input)
        {
            var lastChar = input.ElementAt(0);
            var value = 0;
            var index = 0;
            foreach (var s in input)
            {
                var compareDigit = this.GetCompareDigit(input, index);
                if (compareDigit == s)
                {
                    value += Convert.ToInt32(s - 48);
                }

                index++;
            }

            return value;
        }

        private char GetCompareDigit(string input, int index)
        {
            var toSkip = input.Length / 2;
            var input2 = input + input;
            return input2[index + toSkip];
        }
    }
}
