using GreatesCommonDivisor;
using NUnit.Framework;

namespace GreatestCommonDivisor_Test
{
    public class Tests
    {
        [Test]
        public void Should_Add_Fractions()
        {
            var f1 = new Fraction(1, 2);
            Fraction f2 = new(3, 4);

            var expected = new Fraction(5, 4);
            var actual = Kata.Add(f1, f2);

            //Assert.AreEqual(expected, actual);
            //Assert.Equals(expected, actual);
            //Assert.AreEqual("5 / 3", actual);
            Assert.IsTrue(expected.Equal(actual));
        }
    }
}