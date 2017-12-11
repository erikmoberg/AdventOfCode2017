using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day08Star2Tests
    {
        [TestMethod]
        public void Day08Star2Test1()
        {
            var input = this.GetFileInput("Day08Test1.txt");
            Assert.AreEqual(10, this.Get(input));
        }

        [TestMethod]
        public void Day08Star2Test2()
        {
            var input = this.GetFileInput("Day08.txt");
            Assert.AreEqual(8186, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string[] input)
        {
            var target = new Day08Star2();
            return target.Get(input);
        }
    }
}
