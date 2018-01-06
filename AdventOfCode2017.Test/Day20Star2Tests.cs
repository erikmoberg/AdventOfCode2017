using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day20Star2Tests : TestBase<Day20Star2, string[], int>
    {
        [TestMethod]
        public void Day20Star2Test1()
        {
            var input = this.GetFileInput("Day20Test2.txt");
            Assert.AreEqual(1, this.Get(input));
        }

        [TestMethod]
        public void Day20Star2Test2()
        {
            var input = this.GetFileInput("Day20.txt");
            Assert.AreEqual(571, this.Get(input));
        }
    }
}
