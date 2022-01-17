using GreatesCommonDivisor;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new(1, 2);
            Fraction f2 = new(3, 4);
            var result = Kata.Add(f1, f2);

            var expected = new Fraction(5, 4);
            var actual = Kata.Add(f1, f2);

            Console.WriteLine(Kata.gcd(113,84));
            //Console.WriteLine(Kata.GCD(3, 4));
            //Console.WriteLine($"Fraction: {result.numerator} / {result.denominator}");
        }
    }
}
