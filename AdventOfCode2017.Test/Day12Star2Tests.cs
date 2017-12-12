using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day12Star2Tests : TestBase<Day12Star2, string[], int>
    {
        [TestMethod]
        public void Day12Star2Test1()
        {
            var input = this.GetFileInput("Day12Test1.txt");
            Assert.AreEqual(2, this.Get(input));
        }

        [TestMethod]
        public void Day12Star2Test2()
        {
            var input = this.GetFileInput("Day12.txt");
            Assert.AreEqual(202, this.Get(input));
        }
    }
}
