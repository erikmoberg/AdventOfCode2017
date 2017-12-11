using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day10Star2Tests : TestBase<Day10Star2, string, string>
    {
        [TestMethod]
        public void Day10Star2Test1()
        {
            var input = string.Empty;
            Assert.AreEqual("a2582a3a0e66e6e86e3812dcb672a272", this.Get(input));
        }

        [TestMethod]
        public void Day10Star2Test2()
        {
            var input = "AoC 2017";
            Assert.AreEqual("33efeb34ea91902bb2f59c9920caa6cd", this.Get(input));
        }

        [TestMethod]
        public void Day10Star2Test3()
        {
            var input = "1,2,3";
            Assert.AreEqual("3efbe78a8d82f29979031a4aa0b16a9d", this.Get(input));
        }

        [TestMethod]
        public void Day10Star2Test4()
        {
            var input = "1,2,4";
            Assert.AreEqual("63960835bcdc130f0b66d7ff4f6a5a8e", this.Get(input));
        }

        [TestMethod]
        public void Day10Star2Test5()
        {
            var input = this.GetFileInput("Day10.txt").Single();
            Assert.AreEqual("20b7b54c92bf73cf3e5631458a715149", this.Get(input));
        }
    }
}
