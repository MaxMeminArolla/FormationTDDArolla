using NUnit.Framework;

namespace GreatestCommonDivisor_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        struct Fraction
        {
            public int numerator { get;set }
            public int denominator { get; set; }
        }

        [Test]
        public void Fraction_cannot_be_mutated()
        {
            Fraction f1 = new()
            {
                numerator = 1,
                denominator = 2
            };
            Kata.add(f1, f1);
        }
    }
}