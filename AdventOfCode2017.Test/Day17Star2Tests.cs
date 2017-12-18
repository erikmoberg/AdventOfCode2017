using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day17Star2Tests : TestBase<Day17Star2, int, int>
    {
        [TestMethod]
        public void Day17Star2Test1()
        {
            var input = 303;
            Assert.AreEqual(17202899, this.Get(input));
        }
    }
}
