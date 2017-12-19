using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day19Star2Tests : TestBase<Day19Star2, string[], int>
    {
        [TestMethod]
        public void Day19Star2Test1()
        {
            var input = this.GetFileInput("Day19Test1.txt");
            Assert.AreEqual(38, this.Get(input));
        }

        [TestMethod]
        public void Day19Star2Test2()
        {
            var input = this.GetFileInput("Day19.txt");
            Assert.AreEqual(16204, this.Get(input));
        }
    }
}
