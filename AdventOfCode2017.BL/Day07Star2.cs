using AdventOfCode2017.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day07Star2
    {
        public int Get(string[] input)
        {
            var flatList = CreateFlatList(input);
            var withParents = flatList.Where(x => x.Children != null).SelectMany(x => x.Children).Select(x => x.Name);
            var root = flatList.Single(x => withParents.All(y => y != x.Name));
            var flatList2 = new List<Entry>();
            Step(flatList, flatList2, root, 0);
            for (var i = flatList2.Max(x => x.Level) - 1; i > 0; i--)
            {
                var entries = flatList2.Where(x => x.Level == i);
                var parents = entries.GroupBy(x => x.Parent);
                foreach(var children in parents)
                {
                    //var entries = parent;
                    var grouped = children.GroupBy(x => x.Sum);
                    var found = grouped.Where(x => x.Count() != children.Count());
                    if (found.Any())
                    {
                        var wrong = found.FirstOrDefault(x => x.Count() == 1).FirstOrDefault();
                        var correct = found.FirstOrDefault(x => x.Count() != 1).FirstOrDefault();
                        return wrong.Weight + (correct.Sum - wrong.Sum);
                    }
                }
            }

            return -1;
        }

        private static void Step(List<Entry> flatList, List<Entry> flatList2, Entry node, int level)
        {
            var e = flatList.Single(x => x.Name == node.Name);
            if (e.Children == null)
            {
                return;
            }

            level++;
            node.Children = e.Children.Select(x => flatList.Single(f => f.Name == x.Name)).Select(x => new Entry { Name = x.Name, Weight = x.Weight, Level = level, Parent = node }).ToArray();
            flatList2.AddRange(node.Children);
            foreach (var c in node.Children)
            {
                Step(flatList, flatList2, c, level);
            }
        }

        private static List<Entry> CreateFlatList(string[] input)
        {
            var entries = new List<Entry>();
            foreach (var line in input)
            {
                var parts = line.Split(new[] { "->" }, StringSplitOptions.None).Select(x => x.Trim()).ToArray();
                var e = new Entry
                {
                    Name = parts[0].Substring(0, parts[0].IndexOf(' ')),
                    Weight = int.Parse(parts[0].Substring(parts[0].IndexOf(' ') + 2).Replace(")", string.Empty))
                };

                if (parts.Count() > 1)
                {
                    e.Children = parts[1].Split(new[] { "," }, StringSplitOptions.None).Select(x => new Entry { Name = x.Trim() }).ToArray();
                }

                entries.Add(e);
            }

            return entries;
        }
    }
}