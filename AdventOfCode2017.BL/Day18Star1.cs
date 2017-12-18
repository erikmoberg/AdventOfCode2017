using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day18Star1 : IResultGenerator<long, string[]>
    {
        public long Get(string[] input)
        {
            var instructions = input.Select(x =>
            {
                var parts = x.Split(' ');
                return new
                {
                    Operation = parts[0],
                    Register = parts[1],
                    Value = parts.Length == 3 ? parts[2] : null
                };
            }).ToArray();

            var lastPlayed = -1L;
            var registers = instructions.Select(x => x.Register).Distinct().Where(x => char.IsLetter(x[0])).ToDictionary(x => x, x => 0L);
            for (long i = 0; i < instructions.Length; i++)
            {
                switch (instructions[i].Operation)
                {
                    case "snd":
                        lastPlayed = registers[instructions[i].Register];
                        break;
                    case "set":
                        registers[instructions[i].Register] = GetValue(registers, instructions[i].Value);
                        break;
                    case "add":
                        registers[instructions[i].Register] += GetValue(registers, instructions[i].Value);
                        break;
                    case "mul":
                        registers[instructions[i].Register] *= GetValue(registers, instructions[i].Value);
                        break;
                    case "mod":
                        registers[instructions[i].Register] %= GetValue(registers, instructions[i].Value);
                        break;
                    case "rcv":
                        if (registers[instructions[i].Register] != 0 && lastPlayed != 0)
                        {
                            return lastPlayed;
                        }
                        break;
                    case "jgz":
                        if (GetValue(registers, instructions[i].Register) > 0)
                        {
                            i += (GetValue(registers, instructions[i].Value) - 1);
                        }
                        break;
                }
            }

            throw new InvalidOperationException();
        }

        private long GetValue(Dictionary<string, long> registers, string value)
        {
            return registers.ContainsKey(value) ? registers[value] : long.Parse(value);
        }
    }
}