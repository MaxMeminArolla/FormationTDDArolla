using System;
using System.Linq;
using System.Text;

namespace PrintDiamond
{
    public class Kata
    {
        public const string rc = "\r\n";
        const char space = ' ';

        public static string printDiamond(char letter)
        {
            var asciiPosition = ASCIIEncoding.ASCII.GetBytes(letter.ToString())[0];
            var gap = asciiPosition - 'A';

            byte[] alphaBytes = Enumerable.Range('A', 'Z').Select(n => (byte)n).ToArray();
            ASCIIEncoding.ASCII.GetString(alphaBytes);

            var gapSupDiamond = gap;
            var gapInfDiamond = 1;
            var gapBetweenLetters = 'A';

            StringBuilder sb = new(new String(space, gapSupDiamond--) + "A" + rc);

            for (byte i = 'A' + 1; i <= asciiPosition; i++)
            {
                sb.Append(new String(space, gapSupDiamond--));                          //spaces
                sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { i }));             //letter
                sb.Append(new String(space, i - gapBetweenLetters--));                  //spaces
                if(i != 'A') sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { i }));//letter

                sb.AppendLine();
            }

            for (byte j = (byte)(asciiPosition - 1); j >= 'A'; j--)
            {
                sb.Append(new String(space, gapInfDiamond++));
                sb.Append(ASCIIEncoding.ASCII.GetString(new byte[] { j }));            
                if (j != 'A')
                {
                    sb.Append(new String(space, j - gapBetweenLetters++ - 2));
                    sb.AppendLine(ASCIIEncoding.ASCII.GetString(new byte[] { j }));
                }
            }
            return sb.ToString();
        }
    }
}
