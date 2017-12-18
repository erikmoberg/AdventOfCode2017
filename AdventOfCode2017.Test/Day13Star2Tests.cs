using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day13Star2Tests : TestBase<Day13Star2, string[], int>
    {
        [TestMethod]
        public void Day13Star2Test1()
        {
            var input = this.GetFileInput("Day13Test1.txt");
            Assert.AreEqual(10, this.Get(input));
        }

        [TestMethod]
        public void Day13Star2Test2()
        {
            var input = this.GetFileInput("Day13.txt");
            Assert.AreEqual(3905748, this.Get(input));
        }
    }
}
