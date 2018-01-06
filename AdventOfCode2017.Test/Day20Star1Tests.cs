using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day20Star1Tests : TestBase<Day20Star1, string[], int>
    {
        [TestMethod]
        public void Day20Star1Test1()
        {
            var input = this.GetFileInput("Day20Test1.txt");
            Assert.AreEqual(0, this.Get(input));
        }

        [TestMethod]
        public void Day20Star1Test2()
        {
            var input = this.GetFileInput("Day20.txt");
            Assert.AreEqual(170, this.Get(input));
        }
    }
}
