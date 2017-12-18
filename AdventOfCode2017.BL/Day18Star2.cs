using AdventOfCode2017.BL.Model;
using System.Linq;
using System.Threading;

namespace AdventOfCode2017.BL
{
    public class Day18Star2 : IResultGenerator<long, string[]>
    {
        public long Get(string[] input)
        {
            var instructions = input.Select(x =>
            {
                var parts = x.Split(' ');
                return new Instruction
                {
                    Operation = parts[0],
                    Register = parts[1],
                    Value = parts.Length == 3 ? parts[2] : null
                };
            }).ToArray();

            var p0 = new Processor(0, instructions);
            var p1 = new Processor(1, instructions);
            p0.Send = p1.Receive;
            p1.Send = p0.Receive;

            p0.Start();
            p1.Start();

            while (!(p0.HasDeadlocked && p1.HasDeadlocked))
            {
                Thread.Sleep(10);
            }

            return p1.SentValues;
        }
    }
}