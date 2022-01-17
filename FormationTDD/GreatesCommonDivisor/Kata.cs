using System;
using System.ComponentModel;

namespace GreatesCommonDivisor
{
    public class Fraction
    {
        public readonly int numerator;
        public readonly int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public bool Equal(Fraction other)
        {
            if (this.numerator == other.numerator 
             && this.denominator == other.denominator) return true;
            return false;
        }
    }

    public class Kata
    {
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            var num1 = f1.numerator * f2.denominator;
            var num2 = f2.numerator * f1.denominator;
            var totalNum = num1 + num2;
            var denominator = f1.denominator * f2.denominator;
            var gcd = Kata.gcd(totalNum, denominator);

            return new Fraction(totalNum / gcd, denominator / gcd);
            //return $"{totalNum / gcd} / {denominator / gcd}";
        }

        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
