using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day18Star1Tests : TestBase<Day18Star1, string[], long>
    {
        [TestMethod]
        public void Day18Star1Test1()
        {
            var input = this.GetFileInput("Day18Test1.txt");
            Assert.AreEqual(4, this.Get(input));
        }

        [TestMethod]
        public void Day18Star1Test2()
        {
            var input = this.GetFileInput("Day18.txt");
            Assert.AreEqual(9423, this.Get(input));
        }
    }
}
