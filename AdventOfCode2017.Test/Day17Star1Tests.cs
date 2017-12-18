using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day17Star1Tests : TestBase<Day17Star1, int, int>
    {
        [TestMethod]
        public void Day17Star1Test1()
        {
            var input = 3;
            Assert.AreEqual(638, this.Get(input));
        }

        [TestMethod]
        public void Day17Star1Test2()
        {
            var input = 303;
            Assert.AreEqual(1971, this.Get(input));
        }
    }
}
