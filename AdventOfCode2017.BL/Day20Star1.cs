using AdventOfCode2017.BL.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2017.BL
{
    public class Day20Star1 : IResultGenerator<int, string[]>
    {
        public int Get(string[] input)
        {
            var regex = new Regex(@"<([\s0-9,-]*)>");
            var i = 0;
            var particles = input.Select(x =>
            {
                var matches = regex.Matches(x);
                var p = matches[0].Groups[1].Value.Split(',');
                var v = matches[1].Groups[1].Value.Split(',');
                var a = matches[2].Groups[1].Value.Split(',');
                return new
                {
                    Index = i++,
                    P = new SimpleVector3(int.Parse(p[0]), int.Parse(p[1]), int.Parse(p[2])),
                    V = new SimpleVector3(int.Parse(v[0]), int.Parse(v[1]), int.Parse(v[2])),
                    A = new SimpleVector3(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2])),
                };
            }).ToArray();

            var slowest = particles.Where(x => x.A.Length == particles.Min(y => y.A.Length)).ToArray();
            var found = true;
            while (found)
            {
                found = false;
                foreach (var particle in slowest)
                {
                    var velocity = particle.V.Length;
                    var distance = particle.P.Length;

                    particle.V.X += particle.A.X;
                    particle.V.Y += particle.A.Y;
                    particle.V.Z += particle.A.Z;

                    particle.P.X += particle.V.X;
                    particle.P.Y += particle.V.Y;
                    particle.P.Z += particle.V.Z;

                    if (!found && (particle.V.Length <= velocity || particle.P.Length <= distance))
                    {
                        found = true;
                    }
                }
            }

            return slowest.Single(x => Math.Abs(x.V.Length) == slowest.Min(y => y.V.Length)).Index;
        }
    }
}