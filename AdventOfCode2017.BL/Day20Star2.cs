using AdventOfCode2017.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode2017.BL
{
    public class Day20Star2 : IResultGenerator<int, string[]>
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

            var comparer = new SimpleVector3Comparer();
            for (var j = 0; j < 1000; j++)
            {
                foreach (var particle in particles)
                {
                    var velocity = particle.V.Length;
                    var distance = particle.P.Length;

                    particle.V.X += particle.A.X;
                    particle.V.Y += particle.A.Y;
                    particle.V.Z += particle.A.Z;

                    particle.P.X += particle.V.X;
                    particle.P.Y += particle.V.Y;
                    particle.P.Z += particle.V.Z;
                }

                var collided = particles.GroupBy(x => x.P, comparer).Where(x => x.Count() > 1).SelectMany(x => x).ToArray();
                if(collided.Any())
                {
                    particles = particles.Except(collided).ToArray();
                }
            }

            return particles.Length;
        }
    }

    public class SimpleVector3Comparer : IEqualityComparer<SimpleVector3>
    {
        public bool Equals(SimpleVector3 x, SimpleVector3 y)
        {
            return x == y;
        }

        public int GetHashCode(SimpleVector3 obj)
        {
            return base.GetHashCode();
        }
    }
}