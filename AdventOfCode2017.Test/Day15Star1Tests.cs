using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day15Star1Tests : TestBase<Day15Star1, long, long, int>
    {
        [TestMethod]
        public void Day15Star1Test1()
        {
            Assert.AreEqual(588, this.Get(65, 8921));
        }

        [TestMethod]
        public void Day15Star1Test2()
        {
            Assert.AreEqual(567, this.Get(512, 191));
        }
    }
}
