using System;
using System.Linq;

namespace AdventOfCode2017.BL
{
    public class Day16Star2 : IResultGenerator<string, string, string>
    {
        public string Get(string input, string programs)
        {
            var list = programs.Select(x => x.ToString()).ToList();

            var moves = input.Split(',').ToList().Select(x =>
            {
                var move = x.Substring(0, 1);
                var spinSize = 0;
                var index1 = 0;
                var index2 = 0;
                string program1 = null;
                string program2 = null;

                switch (move)
                {
                    case "s":
                        spinSize = int.Parse(x.Substring(1));
                        break;
                    case "x":
                        index1 = int.Parse(x.Substring(1, x.IndexOf("/") - 1));
                        index2 = int.Parse(x.Substring(x.IndexOf("/") + 1));
                        break;
                    case "p":
                        program1 = x.Substring(1, x.IndexOf("/") - 1);
                        program2 = x.Substring(x.IndexOf("/") + 1);
                        break;
                }

                return new
                {
                    move,
                    spinSize,
                    index1,
                    index2,
                    program1,
                    program2
                };
            }).ToArray();

            for (var j = 0; j < 1000000000 % 60; j++)
            {
                foreach(var move in moves)
                {
                    switch (move.move)
                    {
                        case "s":
                            for (var i = 0; i < move.spinSize; i++)
                            {
                                list.Insert(0, list.Last());
                                list.RemoveAt(list.Count - 1);
                            }
                            break;
                        case "x":
                            var temp = list[move.index1];
                            list[move.index1] = list[move.index2];
                            list[move.index2] = temp;
                            break;
                        case "p":
                            var programIndex1 = list.IndexOf(move.program1);
                            var programIndex2 = list.IndexOf(move.program2);
                            var temp1 = list[programIndex1];
                            list[programIndex1] = list[programIndex2];
                            list[programIndex2] = temp1;
                            break;
                    }
                }
            }

            return string.Join(string.Empty, list);
        }
    }
}