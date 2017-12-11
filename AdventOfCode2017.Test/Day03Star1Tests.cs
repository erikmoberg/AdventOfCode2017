using System;
using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day03Star1Tests
    {
        [TestMethod]
        public void Day03Star1Test1()
        {
            var input = 1;
            Assert.AreEqual(0, this.Get(input));
        }

        [TestMethod]
        public void Day03Star1Test2()
        {
            var input = 12;
            Assert.AreEqual(3, this.Get(input));
        }

        [TestMethod]
        public void Day03Star1Test3()
        {
            var input = 23;
            Assert.AreEqual(2, this.Get(input));
        }

        [TestMethod]
        public void Day03Star1Test4()
        {
            var input = 1024;
            Assert.AreEqual(31, this.Get(input));
        }

        [TestMethod]
        public void Day03Star1Test5()
        {
            var input = 265149;
            Assert.AreEqual(438, this.Get(input));
        }

        private int Get(int input)
        {
            var target = new Day03Star1();
            return target.Get(input);
        }
    }
}
