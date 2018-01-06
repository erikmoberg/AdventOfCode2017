using AdventOfCode2017.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AdventOfCode2017.Test
{
    [TestClass]
    public class Day21Star1Tests : TestBase<Day21Star1, string[], int, int>
    {
        [TestMethod]
        public void Day21Star1Test1()
        {
            var input = this.GetFileInput("Day21Test1.txt");
            Assert.AreEqual(12, this.Get(input, 2));
        }

        [TestMethod]
        public void Day21Star1Test2()
        {
            var input = new[]
            {
                new[] { "A", "B", "C" },
                new[] { "D", "E", "F" },
                new[] { "G", "H", "I" }
            };

            var result = this.GetTarget().Rotate(input);
            var stringified = string.Join(" | ", result.Select(x => string.Join(",", x)));
            var expected = "G,D,A | H,E,B | I,F,C";
            Assert.AreEqual(expected, stringified);
        }

        [TestMethod]
        public void Day21Star1Test3()
        {
            var input = new[]
            {
                new[] { "A", "B" },
                new[] { "C", "D" }
            };

            var result = this.GetTarget().Rotate(input);
            var stringified = string.Join(" | ", result.Select(x => string.Join(",", x)));
            var expected = "C,A | D,B";
            Assert.AreEqual(expected, stringified);
        }

        [TestMethod]
        public void Day21Star1Test4()
        {
            var input = new[]
            {
                new[] { "A", "B", "C" },
                new[] { "D", "E", "F" },
                new[] { "G", "H", "I" }
            };

            var result = this.GetTarget().FlipY(input);
            var stringified = string.Join(" | ", result.Select(x => string.Join(",", x)));
            var expected = "G,H,I | D,E,F | A,B,C";
            Assert.AreEqual(expected, stringified);
        }

        [TestMethod]
        public void Day21Star1Test5()
        {
            var input = new[]
            {
                new[] { "A", "B", "C" },
                new[] { "D", "E", "F" },
                new[] { "G", "H", "I" }
            };

            var result = this.GetTarget().FlipX(input);
            var stringified = string.Join(" | ", result.Select(x => string.Join(",", x)));
            var expected = "C,B,A | F,E,D | I,H,G";
            Assert.AreEqual(expected, stringified);
        }

        [TestMethod]
        public void Day21Star1Test6()
        {
            var input = this.GetFileInput("Day21.txt");
            Assert.AreEqual(186, this.Get(input, 5));
        }
    }
}
