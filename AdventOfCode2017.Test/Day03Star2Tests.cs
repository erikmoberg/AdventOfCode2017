using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day03Star2Tests
    {
        [TestMethod]
        public void Day03Star2Test1()
        {
            var input = 12;
            Assert.AreEqual(23, this.Get(input));
        }

        [TestMethod]
        public void Day03Star2Test2()
        {
            var input = 23;
            Assert.AreEqual(25, this.Get(input));
        }

        [TestMethod]
        public void Day03Star2Test3()
        {
            var input = 1024;
            Assert.AreEqual(1968, this.Get(input));
        }

        [TestMethod]
        public void Day03Star2Test4()
        {
            var input = 265149;
            Assert.AreEqual(266330, this.Get(input));
        }

        private int Get(int input)
        {
            var target = new Day03Star2();
            return target.Get(input);
        }
    }
}
