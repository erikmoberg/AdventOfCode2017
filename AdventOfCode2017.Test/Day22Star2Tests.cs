using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day22Star2Tests : TestBase<Day22Star2, string[], int, int>
    {
        [TestMethod]
        public void Day22Star2Test1()
        {
            var input = this.GetFileInput("Day22Test1.txt");
            Assert.AreEqual(26, this.Get(input, 100));
        }

        [TestMethod]
        public void Day22Star2Test2()
        {
            var input = this.GetFileInput("Day22Test1.txt");
            Assert.AreEqual(2511944, this.Get(input, 10000000));
        }

        [TestMethod]
        public void Day22Star2Test3()
        {
            var input = this.GetFileInput("Day22.txt");
            Assert.AreEqual(2511776, this.Get(input, 10000000));
        }
    }
}
