using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day13Star1Tests : TestBase<Day13Star1, string[], int>
    {
        [TestMethod]
        public void Day13Star1Test1()
        {
            var input = this.GetFileInput("Day13Test1.txt");
            Assert.AreEqual(24, this.Get(input));
        }

        [TestMethod]
        public void Day13Star1Test2()
        {
            var input = this.GetFileInput("Day13.txt");
            Assert.AreEqual(788, this.Get(input));
        }
    }
}
