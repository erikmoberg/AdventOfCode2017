using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day21Star2Tests : TestBase<Day21Star1, string[], int, int>
    {
        [TestMethod]
        public void Day21Star2Test1()
        {
            var input = this.GetFileInput("Day21.txt");
            Assert.AreEqual(3018423, this.Get(input, 18));
        }
    }
}
