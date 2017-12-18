using System;
using System.Collections.Generic;

namespace AdventOfCode2017.BL
{
    public class Day15Star2 : IResultGenerator<int, long, long>
    {
        public int Get(long generatorA, long generatorB)
        {
            var valueA = generatorA;
            var valueB = generatorB;
            const int mask = 65535;
            const int comparisons = 5000000;
            var valuesA = new Queue<long>(comparisons);
            var valuesB = new Queue<long>(comparisons);
            var score = 0;
            var hasChange = false;
            for (var j = 0; j < comparisons;)
            {
                valueA = (valueA * 16807) % 2147483647;
                valueB = (valueB * 48271) % 2147483647;

                if (valuesA.Count + j < comparisons && valueA % 4 == 0)
                {
                    valuesA.Enqueue(valueA);
                    hasChange = true;
                }

                if (valueB % 8 == 0)
                {
                    valuesB.Enqueue(valueB);
                    hasChange = true;
                }

                if (hasChange)
                {
                    for (var i = 0; i < Math.Min(valuesA.Count, valuesB.Count); i++)
                    {
                        score += (valuesA.Dequeue() & mask) == (valuesB.Dequeue() & mask) ? 1 : 0;
                        j++;
                    }
                }

                hasChange = false;
            }

            return score;
        }
    }
}