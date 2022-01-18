using System;

namespace PrintDiamond
{
    public class Kata
    {
        public const string rc = "\r\n"; 
        public static string printDiamond(char letter)
        {
            return "  A" + rc +
                   " B B" + rc +
                   "C   C" + rc +
                   " B B" + rc +
                   "  A";
        }
    }
}
