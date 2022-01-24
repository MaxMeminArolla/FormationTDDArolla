using NUnit.Framework;
using PrintDiamond;

namespace PrintDiamond_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_display_a_diamond_with_a_string_with_5_lines()
        {
            var result = Kata.printDiamond('C');

            var expected = "  A" + Kata.rc +
                   " B B" + Kata.rc +
                   "C   C" + Kata.rc +
                   " B B" + Kata.rc +
                   "  A";

            TestContext.WriteLine("Expected:{0}{1}", System.Environment.NewLine, expected);
            TestContext.WriteLine("Result:{0}{1}", System.Environment.NewLine, result);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Should_display_a_diamond_with_a_string_until_Z()
        {
            var result = Kata.printDiamond('Z');

            var expected = "  A" + Kata.rc +
                   " B B" + Kata.rc +
                   "C   C" + Kata.rc +
                   " B B" + Kata.rc +
                   "  A";

            TestContext.WriteLine("Expected:{0}{1}", System.Environment.NewLine, expected);
            TestContext.WriteLine("Result:{0}{1}", System.Environment.NewLine, result);

            Assert.AreEqual(expected, result);
        }
    }
}