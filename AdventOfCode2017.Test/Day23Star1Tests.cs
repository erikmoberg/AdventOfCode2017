using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day23Star1Tests : TestBase<Day23Star1, string[], int>
    {
        [TestMethod]
        public void Day23Star1Test1()
        {
            var input = this.GetFileInput("Day23.txt");
            Assert.AreEqual(3025, this.Get(input));
        }
    }
}
