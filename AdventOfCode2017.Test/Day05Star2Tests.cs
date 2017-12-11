using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day05Star2Tests
    {
        [TestMethod]
        public void Day05Star2Test1()
        {
            var input = new[] { 0, 3,  0,  1, - 3 };
            Assert.AreEqual(10, this.Get(input));
        }

        [TestMethod]
        public void Day05Star2Test2()
        {
            var input = this.GetFileInput("Day05.txt").Select(x => Convert.ToInt32(x)).ToArray();
            Assert.AreEqual(21841249, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(int[] input)
        {
            var target = new Day05Star2();
            return target.Get(input);
        }
    }
}
