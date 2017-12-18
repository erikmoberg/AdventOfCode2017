using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day15Star2Tests : TestBase<Day15Star2, long, long, int>
    {
        [TestMethod]
        public void Day15Star2Test1()
        {
            Assert.AreEqual(309, this.Get(65, 8921));
        }

        [TestMethod]
        public void Day15Star2Test2()
        {
            Assert.AreEqual(323, this.Get(512, 191));
        }
    }
}
