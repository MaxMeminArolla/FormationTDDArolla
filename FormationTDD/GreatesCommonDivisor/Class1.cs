using System;

namespace GreatesCommonDivisor
{
    public class Class1
    {
        public static int gcd(int a, int b)
        {
            return b == 0 ? a : gcd(b, a % b);
        }
    }
}
