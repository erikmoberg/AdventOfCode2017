using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day04Star1Tests
    {
        [TestMethod]
        public void Day04Star1Test1()
        {
            var input = "aa bb cc dd ee";
            Assert.AreEqual(1, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star1Test2()
        {
            var input = "aa bb cc dd aa";
            Assert.AreEqual(0, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star1Test3()
        {
            var input = "aa bb cc dd aaa";
            Assert.AreEqual(1, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star1Test4()
        {
            var input = this.GetFileInput("Day04.txt");
            Assert.AreEqual(383, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string[] input)
        {
            var target = new Day04Star1();
            return target.Get(input);
        }
    }
}
