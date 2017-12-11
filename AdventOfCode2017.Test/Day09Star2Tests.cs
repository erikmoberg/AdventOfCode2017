using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day09Star2Tests
    {
        [TestMethod]
        public void Day09Star2Test1()
        {
            var input = "<>";
            Assert.AreEqual(0, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test2()
        {
            var input = "<random characters>";
            Assert.AreEqual(17, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test3()
        {
            var input = "<<<<>";
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test4()
        {
            var input = "<{!>}>";
            Assert.AreEqual(2, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test5()
        {
            var input = "<!!>";
            Assert.AreEqual(0, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test6()
        {
            var input = "<!!!>>";
            Assert.AreEqual(0, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test7()
        {
            var input = "<{o\"i!a,<{i<a>";
            Assert.AreEqual(10, this.Get(input));
        }

        [TestMethod]
        public void Day09Star2Test8()
        {
            var input = this.GetFileInput("Day09.txt").Single();
            Assert.AreEqual(6346, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string input)
        {
            var target = new Day09Star2();
            return target.Get(input);
        }
    }
}
