using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day14Star1Tests : TestBase<Day14Star1, string, int>
    {
        [TestMethod]
        public void Day14Star1Test1()
        {
            var input = "flqrgnkx";
            Assert.AreEqual(8108, this.Get(input));
        }

        [TestMethod]
        public void Day14Star1Test2()
        {
            var input = "oundnydw";
            Assert.AreEqual(8106, this.Get(input));
        }
    }
}
