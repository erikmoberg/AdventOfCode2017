using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day12Star1Tests : TestBase<Day12Star1, string[], int>
    {
        [TestMethod]
        public void Day12Star1Test1()
        {
            var input = this.GetFileInput("Day12Test1.txt");
            Assert.AreEqual(6, this.Get(input));
        }

        [TestMethod]
        public void Day12Star1Test2()
        {
            var input = this.GetFileInput("Day12.txt");
            Assert.AreEqual(113, this.Get(input));
        }
    }
}
