using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day22Star1Tests : TestBase<Day22Star1, string[], int, int>
    {
        [TestMethod]
        public void Day22Star1Test1()
        {
            var input = this.GetFileInput("Day22Test1.txt");
            Assert.AreEqual(5, this.Get(input, 7));
        }

        [TestMethod]
        public void Day22Star1Test2()
        {
            var input = this.GetFileInput("Day22Test1.txt");
            Assert.AreEqual(41, this.Get(input, 70));
        }

        [TestMethod]
        public void Day22Star1Test3()
        {
            var input = this.GetFileInput("Day22Test1.txt");
            Assert.AreEqual(5587, this.Get(input, 10000));
        }

        [TestMethod]
        public void Day22Star1Test4()
        {
            var input = this.GetFileInput("Day22.txt");
            Assert.AreEqual(5399, this.Get(input, 10000));
        }
    }
}
