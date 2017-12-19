using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day19Star1Tests : TestBase<Day19Star1, string[], string>
    {
        [TestMethod]
        public void Day19Star1Test1()
        {
            var input = this.GetFileInput("Day19Test1.txt");
            Assert.AreEqual("ABCDEF", this.Get(input));
        }

        [TestMethod]
        public void Day19Star1Test2()
        {
            var input = this.GetFileInput("Day19.txt");
            Assert.AreEqual("GPALMJSOY", this.Get(input));
        }
    }
}
