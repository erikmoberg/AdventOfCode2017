namespace AdventOfCode2017.BL
{
    public class Day15Star1 : IResultGenerator<int, long, long>
    {
        public int Get(long generatorA, long generatorB)
        {
            var previousValueA = generatorA;
            var previousValueB = generatorB;
            const int mask = 65535;

            var score = 0;
            for (var j = 0; j < 40000000; j++)
            {
                previousValueA = (previousValueA * 16807) % 2147483647;
                previousValueB = (previousValueB * 48271) % 2147483647;
                score += (previousValueA & mask) == (previousValueB & mask) ? 1 : 0;
            }

            return score;
        }
    }
}