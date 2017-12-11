using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day10Star1Tests : TestBase<Day10Star1, string, int, int>
    {
        [TestMethod]
        public void Day10Star1Test1()
        {
            var input = "3,4,1,5";
            Assert.AreEqual(12, this.Get(input, 5));
        }

        [TestMethod]
        public void Day10Star1Test2()
        {
            var input = this.GetFileInput("Day10.txt").Single();
            Assert.AreEqual(9656, this.Get(input, 256));
        }
    }
}
