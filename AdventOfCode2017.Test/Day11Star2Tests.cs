using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day11Star2Tests : TestBase<Day11Star2, string, int>
    {
        [TestMethod]
        public void Day11Star2Test1()
        {
            var input = "ne,ne,ne";
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day11Star2Test2()
        {
            var input = "ne,ne,sw,sw";
            Assert.AreEqual(2, this.Get(input));
        }

        [TestMethod]
        public void Day11Star2Test3()
        {
            var input = "ne,ne,s,s";
            Assert.AreEqual(2, this.Get(input));
        }

        [TestMethod]
        public void Day11Star2Test4()
        {
            var input = "se,sw,se,sw,sw";
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day11Star2Test5()
        {
            var input = this.GetFileInput("Day11.txt").Single();
            Assert.AreEqual(1447, this.Get(input));
        }
    }
}
