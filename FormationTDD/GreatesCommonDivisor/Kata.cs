using System;
using System.ComponentModel;

namespace GreatesCommonDivisor
{
    [ImmutableObject(true)]
    public class Fraction
    {
        public readonly int numerator;
        public readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
    }

    public class Kata
    {
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            return new Fraction(0,0);
        }

        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
