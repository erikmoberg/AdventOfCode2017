using System.IO;
using System.Reflection;

namespace AdventOfCode2017.Test
{
    public class SimpleTestBase
    {
        protected string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }
    }
}