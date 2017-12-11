using AdventOfCode2017.BL.Model;
using System.Text.RegularExpressions;

namespace AdventOfCode2017.BL
{
    public class Day09Star2
    {
        public int Get(string input)
        {
            var regex = new Regex("!.");
            var input2 = regex.Replace(input.Replace("!!", string.Empty), string.Empty);
            MyGroup root = null;
            var currentNode = root;
            foreach (var c in input2)
            {
                if (currentNode == null || !currentNode.IsGarbage)
                {
                    if (c == '{')
                    {
                        currentNode = new MyGroup(currentNode, false);
                    }
                    else if (c == '}')
                    {
                        currentNode = currentNode.Parent;
                    }
                    else if (c == '<')
                    {
                        currentNode = new MyGroup(currentNode, true);
                    }
                }
                else
                {
                    if (c == '>')
                    {
                        currentNode = currentNode.Parent;
                    }
                    else
                    {
                        currentNode.GarbageCount++;
                    }
                }

                root = root ?? currentNode;
            }

            return root.TotalGarbageCount;
        }
    }
}