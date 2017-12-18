using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day16Star1Tests : TestBase<Day16Star1, string, string, string>
    {
        [TestMethod]
        public void Day15Star1Test1()
        {
            var input = "s1,x3/4,pe/b";
            var programs = "abcde";
            Assert.AreEqual("baedc", this.Get(input, programs));
        }

        [TestMethod]
        public void Day15Star1Test2()
        {
            var input = this.GetFileInput("Day16.txt").Single();
            var programs = "abcdefghijklmnop";
            Assert.AreEqual("kbednhopmfcjilag", this.Get(input, programs));
        }
    }
}
