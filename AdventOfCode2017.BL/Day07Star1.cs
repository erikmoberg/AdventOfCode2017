using AdventOfCode2017.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day07Star1
    {
        public string Get(string[] input)
        {
            var entries = new List<Entry>();
            foreach (var line in input)
            {
                var parts = line.Split(new[] { "->" }, StringSplitOptions.None).Select(x => x.Trim()).ToArray();
                var e = new Entry
                {
                    Name = parts[0].Substring(0, parts[0].IndexOf(' '))
                };

                if (parts.Count() > 1)
                {
                    e.Children = parts[1].Split(new[] { "," }, StringSplitOptions.None).Select(x => new Entry { Name = x.Trim() }).ToArray();
                }

                entries.Add(e);
            }

            var withParents = entries.Where(x => x.Children != null).SelectMany(x => x.Children).Select(x => x.Name);
            return entries.Single(x => withParents.All(y => y != x.Name)).Name;
        }
    }
}
