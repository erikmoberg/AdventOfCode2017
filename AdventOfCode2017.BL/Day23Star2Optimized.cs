using System;

namespace AdventOfCode2017.BL
{
    public class Day23Star2Optimized : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var number = 105700;
            var hits = 0;

            for (var i = 0; i <= 1000; i++)
            {
                hits += IsPrime(number) ? 0 : 1;
                number += 17;
            }

            return hits;
        }

        private static bool IsPrime(int number)
        {
            var to = (int)Math.Sqrt(number);
            for (var d = 2; d < to; d++)
            {
                if (number % d == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}