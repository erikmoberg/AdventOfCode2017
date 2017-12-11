using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day06Star2Tests
    {
        [TestMethod]
        public void Day06Star2Test1()
        {
            var input = new[] { 0, 2, 7, 0 };
            Assert.AreEqual(4, this.Get(input));
        }

        [TestMethod]
        public void Day06Star2Test2()
        {
            var input = this.GetFileInput("Day06.txt").Single().Split('\t').Select(x => Convert.ToInt32(x)).ToArray();
            Assert.AreEqual(8038, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(int[] input)
        {
            var target = new Day06Star2();
            return target.Get(input);
        }
    }
}
