using GreatesCommonDivisor;
using NUnit.Framework;

namespace GreatestCommonDivisor_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Should_Add_Fractions()
        {
            Fraction f1 = new(1, 2);
            Fraction f2 = new(3, 4);

            Assert.AreEqual(new Fraction(5, 4), Kata.Add(f1, f2));
        }
    }
}