using AdventOfCode2017.BL.Model;
using System.Text.RegularExpressions;

namespace AdventOfCode2017.BL
{
    public class Day09Star1
    {
        public int Get(string input)
        {
            var regex = new Regex("!.");
            var input2 = regex.Replace(input.Replace("!!", string.Empty), string.Empty);
            var root = new MyGroup(null, false);
            var currentNode = root;
            for (var i = 1; i < input2.Length - 1; i++)
            {
                if (!currentNode.IsGarbage)
                {
                    if (input2[i] == '{')
                    {
                        currentNode = new MyGroup(currentNode, false);
                    }
                    else if (input2[i] == '}')
                    {
                        currentNode = currentNode.Parent;
                    }
                    else if (input2[i] == '<')
                    {
                        currentNode = new MyGroup(currentNode, true);
                    }
                }
                else
                {
                    if (input2[i] == '>')
                    {
                        currentNode = currentNode.Parent;
                    }
                }
            }

            return root.TotalScore;
        }
    }
}