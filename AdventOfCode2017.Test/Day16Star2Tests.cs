using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day16Star2Tests : TestBase<Day16Star2, string, string, string>
    {
        [TestMethod]
        public void Day16Star2Test1()
        {
            var input = "s1,x3/4,pe/b";
            var programs = "abcde";
            Assert.AreEqual("abcde", this.Get(input, programs));
        }

        [TestMethod]
        public void Day16Star2Test2()
        {
            var input = this.GetFileInput("Day16.txt").Single();
            var programs = "abcdefghijklmnop";
            Assert.AreEqual("fbmcgdnjakpioelh", this.Get(input, programs));
        }
    }
}
