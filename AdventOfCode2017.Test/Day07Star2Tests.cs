using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day07Star2Tests
    {
        [TestMethod]
        public void Day07Star2Test1()
        {
            var input = this.GetFileInput("Day07Test1.txt");
            Assert.AreEqual(60, this.Get(input));
        }

        [TestMethod]
        public void Day07Star2Test2()
        {
            var input = this.GetFileInput("Day07.txt");
            Assert.AreEqual(1674, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string[] input)
        {
            var target = new Day07Star2();
            return target.Get(input);
        }
    }
}
