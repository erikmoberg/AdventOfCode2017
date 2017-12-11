using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day07Star1Tests
    {
        [TestMethod]
        public void Day07Star1Test1()
        {
            var input = this.GetFileInput("Day07Test1.txt");
            Assert.AreEqual("tknk", this.Get(input));
        }

        [TestMethod]
        public void Day07Star1Test2()
        {
            var input = this.GetFileInput("Day07.txt");
            Assert.AreEqual("vmpywg", this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private string Get(string[] input)
        {
            var target = new Day07Star1();
            return target.Get(input);
        }
    }
}
