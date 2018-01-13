namespace AdventOfCode2017.BL
{
    using System.Linq;

    public class Day23Star1 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var registers = Enumerable.Range(0, 8).ToDictionary(x => (char)(97 + x), x => 0);
            var lines = input.Select(x =>
            {
                var parts = x.Split(' ');
                int value1;
                var hasValue1 = int.TryParse(parts[1], out value1);
                int value2;
                var hasValue2 = int.TryParse(parts[2], out value2);
                return new
                {
                    Instruction = parts[0],
                    Register1 = hasValue1 ? default(char) : parts[1][0],
                    Register1Value = hasValue1 ? (int?)value1 : null,
                    Register2 = hasValue2 ? default(char) : parts[2][0],
                    Register2Value = hasValue2 ? (int?)value2 : null,
                    Line = x
                };
            }).ToArray();
            
            var position = 0;
            var numberOfMultiplications = 0;
            while (position >= 0 && position < lines.Length)
            {
                var line = lines[position];
                switch (line.Instruction)
                {
                    case "set":
                        registers[line.Register1] = line.Register2Value ?? registers[line.Register2];
                        break;
                    case "sub":
                        registers[line.Register1] -= line.Register2Value ?? registers[line.Register2];
                        break;
                    case "mul":
                        registers[line.Register1] *= line.Register2Value ?? registers[line.Register2];
                        numberOfMultiplications++;
                        break;
                    case "jnz":
                        if ((line.Register1Value ?? registers[line.Register1]) != 0)
                        {
                            position += line.Register2Value ?? registers[line.Register2];
                            continue;
                        }
                        break;
                }

                position++;
            }

            return numberOfMultiplications;
        }
    }
}