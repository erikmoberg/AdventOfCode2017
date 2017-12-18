using System;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day16Star1 : IResultGenerator<string, string, string>
    {
        public string Get(string input, string programs)
        {
            var list = programs.Select(x => x.ToString()).ToList();
            input.Split(',').ToList().ForEach(x =>
            {
                var move = x.Substring(0, 1);
                switch (move)
                {
                    case "s":
                        var spinSize = int.Parse(x.Substring(1));
                        for (var i = 0; i < spinSize; i++)
                        {
                            list.Insert(0, list.Last());
                            list.RemoveAt(list.Count - 1);
                        }
                        break;
                    case "x":
                        var index1 = int.Parse(x.Substring(1, x.IndexOf("/") - 1));
                        var index2 = int.Parse(x.Substring(x.IndexOf("/") + 1));
                        var temp = list[index1];
                        list[index1] = list[index2];
                        list[index2] = temp;
                        break;
                    case "p":
                        var program1 = x.Substring(1, x.IndexOf("/") - 1);
                        var program2 = x.Substring(x.IndexOf("/") + 1);
                        var programIndex1 = list.IndexOf(program1);
                        var programIndex2 = list.IndexOf(program2);
                        var temp1 = list[programIndex1];
                        list[programIndex1] = list[programIndex2];
                        list[programIndex2] = temp1;
                        break;
                }
            });

            return string.Join(string.Empty, list);
        }
    }
}