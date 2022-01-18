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

            Assert.AreSame("  A" + Kata.rc +
                   " B B" + Kata.rc +
                   "C   C" + Kata.rc +
                   " B B" + Kata.rc +
                   "  A", result);
        }
    }
}