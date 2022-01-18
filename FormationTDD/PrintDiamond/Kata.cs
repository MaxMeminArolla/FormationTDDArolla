using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace PrintDiamond
{
    public class Kata
    {
        public const string rc = "\r\n";
        const int firstAsciiUpperLetter = 65;
        const char space = ' ';

        public static string printDiamond(char letter)
        {
            var asciiPosition = ASCIIEncoding.ASCII.GetBytes(letter.ToString())[0];
            var gap = asciiPosition - firstAsciiUpperLetter;

            //alphabet majuscule en ASCII: 65 à 90
            byte[] alphaByes = Enumerable.Range(65, 26).Select(n => (byte)n).ToArray();
            ASCIIEncoding.ASCII.GetString(alphaByes);

            var gapSupDiamond = gap;
            var gapInfDiamond = 1;
            var gapBetweenLetters = firstAsciiUpperLetter;

            StringBuilder sb = new(new String(space, gapSupDiamond--) + "A" + rc);

            for (byte i = firstAsciiUpperLetter + 1; i <= asciiPosition; i++)
            {
                sb.Append(new String(space, gapSupDiamond--));                          //spaces
                sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { i }));             //letter
                sb.Append(new String(space, i - gapBetweenLetters--));                  //spaces
                if(i != 65) sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { i })); //letter
                sb.AppendLine();
            }

            for (byte j = (byte)(asciiPosition - 1); j >= firstAsciiUpperLetter; j--)
            {
                sb.Append(new String(space, gapInfDiamond++));
                sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { j }));            
                if (j != 65)
                {
                    sb.Append(new String(space, j - gapBetweenLetters++ - 2));
                    sb.AppendLine(ASCIIEncoding.ASCII.GetString(new byte[] { j }));
                }
            }
            return sb.ToString();
        }
    }
}
