using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdventOfCode2017.BL
{
    public class Day21Star1 : IResultGenerator<int, string[], int>
    {
        public int Get(string[] input, int iterations)
        {
            var rules = new ConcurrentDictionary<string, string[][]>();
            foreach (var line in input)
            {
                var parts = line.Split(new[] { " => " }, StringSplitOptions.RemoveEmptyEntries);
                var from = parts[0].Split('/').Select(x => x.Select(y => y.ToString()).ToArray()).ToArray();
                var to = parts[1].Split('/').Select(x => x.Select(y => y.ToString()).ToArray()).ToArray();
                Parallel.ForEach(this.GetCombinations(from), combination =>
                {
                    rules.TryAdd(combination, to);
                });
            }

            var current = new[]
            {
                new[] { ".", "#", "." },
                new[] { ".", ".", "#" },
                new[] { "#", "#", "#" }
            };

            for (var i = 0; i < iterations; i++)
            {
                var matches = new List<string[][]>();
                foreach (var slice in ExtractGrid(iterations, rules, current))
                {
                    var stringified = string.Join(string.Empty, slice.SelectMany(x => x.Select(y => y)));
                    matches.Add(rules[stringified]);
                }

                var increaseBy = current.Length % 2 == 0 ? current.Length / 2 : current.Length / 3;
                var newSideLength = current.Length + increaseBy;
                var target = GetGrid(newSideLength);

                for (var j = 0; j < matches.Count; j++)
                {
                    for (var k = 0; k < matches[j].Length; k++)
                    {
                        for (var m = 0; m < matches[j].Length; m++)
                        {
                            var y = k + (matches[j].Length * ((j * matches[j].Length) / target.Length));
                            var x = m + (((j * matches[j].Length) % target.Length));
                            target[y][x] = matches[j][k][m];
                        }
                    }
                }

                current = target;
            }

            return current.SelectMany(x => x.Select(y => y)).Count(x => x == "#");
        }

        private static string[][] GetGrid(int newSideLength)
        {
            var target = new string[newSideLength][];
            for (var t = 0; t < target.Length; t++)
            {
                target[t] = new string[newSideLength];
            }

            return target;
        }

        private static IEnumerable<string[][]> ExtractGrid(int iterations, ConcurrentDictionary<string, string[][]> rules, string[][] current)
        {
            var sliceSize = current.Length % 2 == 0 ? 2 : 3;
            for (var o = 0; o < current.Length; o += sliceSize)
            {
                for (var k = 0; k < current.Length; k += sliceSize)
                {
                    var slice = new List<string[]>();

                    for (var j = o; j < sliceSize + o; j++)
                    {
                        slice.Add(current[j].Skip(k).Take(sliceSize).ToArray());
                    }

                    yield return slice.ToArray();
                }
            }
        }

        private string[] GetCombinations(string[][] from)
        {
            var rotate1 = this.Rotate(from);
            var rotate2 = this.Rotate(rotate1);
            var rotate3 = this.Rotate(rotate2);
            var all = new[] { from, this.FlipX(from), this.FlipY(from), rotate1, this.FlipX(rotate1), this.FlipY(rotate1), rotate2, this.FlipX(rotate2), this.FlipY(rotate2), rotate3, this.FlipX(rotate3), this.FlipY(rotate3) };
            return all.Select(s => string.Join(string.Empty, s.Select(x => string.Join(string.Empty, x)))).ToArray();
        }

        public string[][] FlipX(string[][] from)
        {
            return from.Select(x => x.Reverse().ToArray()).ToArray();
        }

        public string[][] FlipY(string[][] from)
        {
            return from.Reverse().ToArray();
        }

        public string[][] Rotate(string[][] from)
        {
            var sideLength = from[0].Length;
            var result = GetGrid(sideLength);
            for (var i = 0; i < from.Length * from[0].Length; i++)
            {
                var sourcex = i % sideLength;
                var sourcey = i / sideLength;
                var c = from[sourcey][sourcex];
                var targetx = sourcex;
                var targety = sourcey;

                for (var j = 0; j < sideLength - 1; j++)
                {
                    var tempTargetx = targetx < sideLength - 1 && targety == 0 ? targetx + 1
                        : targetx > 0 && targety == sideLength - 1 ? targetx - 1
                        : targetx;

                    targety = targetx == sideLength - 1 && targety < sideLength - 1 ? targety + 1
                        : targetx == 0 && targety > 0 ? targety - 1
                        : targety;

                    targetx = tempTargetx;
                }

                result[targety][targetx] = c.ToString();
            }

            return result;
        }
    }
}