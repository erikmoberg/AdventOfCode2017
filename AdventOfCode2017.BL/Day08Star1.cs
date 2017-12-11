using System.Collections.Concurrent;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day08Star1
    {
        public int Get(string[] input)
        {
            var values = new ConcurrentDictionary<string, int>();
            foreach (var line in input)
            {
                var parts = line.Split(' ');
                var register = parts[0];
                var increase = parts[1] == "inc" ? 1 : -1;
                var changeBy = int.Parse(parts[2]);
                var conditionRegister = parts[4];
                var conditionOperator = parts[5];
                var conditionValue = int.Parse(parts[6]);

                var value = (conditionOperator == "!=" && values.GetOrAdd(conditionRegister, 0) != conditionValue)
                    || (!conditionOperator.Contains("!") && conditionOperator.Contains("=") && values.GetOrAdd(conditionRegister, 0) == conditionValue)
                    || (conditionOperator.Contains("<") && values.GetOrAdd(conditionRegister, 0) < conditionValue)
                    || (conditionOperator.Contains(">") && values.GetOrAdd(conditionRegister, 0) > conditionValue) 
                        ? increase * changeBy 
                        : 0;

                values.AddOrUpdate(register, value, (s, i) => i + value);
            }

            return values.Values.Max();
        }
    }
}