using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day18Star2Tests : TestBase<Day18Star2, string[], long>
    {
        [TestMethod]
        public void Day18Star2Test1()
        {
            var input = this.GetFileInput("Day18Test2.txt");
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day18Star2Test2()
        {
            var input = this.GetFileInput("Day18.txt");
            Assert.AreEqual(7620, this.Get(input));
        }
    }
}
