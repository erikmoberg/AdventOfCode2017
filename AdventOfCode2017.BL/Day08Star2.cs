using Microsoft.CodeAnalysis.CSharp.Scripting;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day08Star2
    {
        public int GetWithRoslyn(string[] input)
        {
            var maxValue = int.MinValue;
            var values = new ConcurrentDictionary<string, int>();
            foreach (var line in input)
            {
                var parts = line.Split(' ');
                var value = CSharpScript.EvaluateAsync<bool>(values.GetOrAdd(parts[4], 0) + parts[5] + int.Parse(parts[6])).Result ? (parts[1] == "inc" ? 1 : -1) * int.Parse(parts[2]) : 0;
                values.AddOrUpdate(parts[0], value, (s, i) => i + value);
                maxValue = Math.Max(maxValue, values.Values.Max());
            }

            return maxValue;
        }

        public int Get(string[] input)
        {
            var maxValue = int.MinValue;
            var values = new Dictionary<string, int>();
            foreach (var line in input)
            {
                var parts = line.Split(' ');
                var register = parts[0];
                var increase = parts[1] == "inc" ? 1 : -1;
                var changeBy = int.Parse(parts[2]);
                var conditionRegister = parts[4];
                var conditionOperator = parts[5];
                var conditionValue = int.Parse(parts[6]);

                if (!values.ContainsKey(register))
                {
                    values.Add(register, 0);
                }

                values[register] += this.ShouldApply(values, conditionOperator, conditionRegister, conditionValue) ? increase * changeBy : 0;
                maxValue = Math.Max(maxValue, values.Values.Max());
            }

            return maxValue;
        }

        private bool ShouldApply(Dictionary<string, int> values, string conditionOperator, string conditionRegister, int conditionValue)
        {
            if (!values.ContainsKey(conditionRegister))
            {
                values.Add(conditionRegister, 0);
            }

            if (conditionOperator == "!=")
            {
                return values[conditionRegister] != conditionValue;
            }

            if (conditionOperator == ("=="))
            {
                return values[conditionRegister] == conditionValue;
            }

            if (conditionOperator == "<")
            {
                return values[conditionRegister] < conditionValue;
            }

            if (conditionOperator == ">")
            {
                return values[conditionRegister] > conditionValue;
            }

            if (conditionOperator == ">=")
            {
                return values[conditionRegister] >= conditionValue;
            }

            if (conditionOperator == "<=")
            {
                return values[conditionRegister] <= conditionValue;
            }

            throw new ArgumentException(conditionOperator);
        }
    }
}