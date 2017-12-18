using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL.Model
{
    internal class Processor
    {
        private long id;
        private Instruction[] instructions;
        private Dictionary<string, long> registers;
        private ConcurrentQueue<long> queue = new ConcurrentQueue<long>();
        private bool hasDeadlocked;
        private long i = 0;
        private object lockObject = new object();

        public Processor(long id, Instruction[] instructions)
        {
            this.id = id;
            this.instructions = instructions;
            this.registers = instructions.Select(x => x.Register).Distinct().Where(x => char.IsLetter(x[0])).ToDictionary(x => x, x => 0L);
            this.registers["p"] = id;
        }

        public Action<long> Send { get; internal set; }

        public long SentValues { get; internal set; }

        public bool HasDeadlocked
        {
            get
            {
                lock (this.lockObject)
                {
                    return this.hasDeadlocked;
                }
            }
            set
            {
                lock (this.lockObject)
                {
                    this.hasDeadlocked = value;
                }
            }
        }

        public void Receive(long value)
        {
            this.queue.Enqueue(value);

            if (this.HasDeadlocked)
            {
                this.HasDeadlocked = false;
                this.Start();
            }
        }

        public void Start()
        {
            var task = new Task(() =>
            {
                for (; i < instructions.Length; i++)
                {
                    switch (instructions[i].Operation)
                    {
                        case "snd":
                            this.SentValues++;
                            this.Send(GetValue(registers, instructions[i].Register));
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
                            long result;
                            if (this.queue.TryDequeue(out result))
                            {
                                registers[instructions[i].Register] = result;
                            }
                            else
                            {
                                this.HasDeadlocked = true;
                                return;
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
            });

            task.Start();
        }

        private long GetValue(Dictionary<string, long> registers, string value)
        {
            return registers.ContainsKey(value) ? registers[value] : long.Parse(value);
        }
    }
}