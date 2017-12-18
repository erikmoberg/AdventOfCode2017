using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day14Star2Tests : TestBase<Day14Star2, string, int>
    {
        [TestMethod]
        public void Day14Star2Test1()
        {
            var input = "flqrgnkx";
            Assert.AreEqual(1242, this.Get(input));
        }

        [TestMethod]
        public void Day14Star2Test2()
        {
            var input = "oundnydw";
            Assert.AreEqual(1164, this.Get(input));
        }
    }
}
