using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Reflection;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day09Star1Tests
    {
        [TestMethod]
        public void Day09Star1Test1()
        {
            var input = "{}";
            Assert.AreEqual(1, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test2()
        {
            var input = "{{{}}}";
            Assert.AreEqual(6, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test3()
        {
            var input = "{{},{}}";
            Assert.AreEqual(5, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test4()
        {
            var input = "{{{},{},{{}}}}";
            Assert.AreEqual(16, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test5()
        {
            var input = "{<a>,<a>,<a>,<a>}";
            Assert.AreEqual(1, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test6()
        {
            var input = "{{<ab>},{<ab>},{<ab>},{<ab>}}";
            Assert.AreEqual(9, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test7()
        {
            var input = "{{<!!>},{<!!>},{<!!>},{<!!>}}";
            Assert.AreEqual(9, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test8()
        {
            var input = "{{<a!>},{<a!>},{<a!>},{<ab>}}";
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day09Star1Test9()
        {
            var input = this.GetFileInput("Day09.txt").Single();
            Assert.AreEqual(12396, this.Get(input));
        }

        private string[] GetFileInput(string filename)
        {
            return File.ReadAllLines(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\input", filename));
        }

        private int Get(string input)
        {
            var target = new Day09Star1();
            return target.Get(input);
        }
    }
}
