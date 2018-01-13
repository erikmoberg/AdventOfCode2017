using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day23Star2Tests : TestBase<Day23Star2Optimized, string[], int>
    {
        [TestMethod]
        public void Day23Star2Test1()
        {
            var input = this.GetFileInput("Day23.txt");
            Assert.AreEqual(915, this.Get(input));
        }
    }
}
