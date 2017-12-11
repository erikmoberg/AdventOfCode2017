using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day04Star2Tests
    {
        [TestMethod]
        public void Day04Star2Test1()
        {
            var input = "abcde fghij";
            Assert.AreEqual(1, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star2Test2()
        {
            var input = "abcde xyz ecdab";
            Assert.AreEqual(0, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star2Test3()
        {
            var input = "a ab abc abd abf abj";
            Assert.AreEqual(1, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star2Test4()
        {
            var input = "iiii oiii ooii oooi oooo";
            Assert.AreEqual(1, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star2Test5()
        {
            var input = "oiii ioii iioi iiio";
            Assert.AreEqual(0, this.Get(new[] { input }));
        }

        [TestMethod]
        public void Day04Star2Test6()
        {
            var input = this.GetFileInput("Day04.txt");
            Assert.AreEqual(265, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string[] input)
        {
            var target = new Day04Star2();
            return target.Get(input);
        }
    }
}
