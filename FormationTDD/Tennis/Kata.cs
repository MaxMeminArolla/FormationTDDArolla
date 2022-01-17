using System;

namespace Tennis
{
    public class Kata
    {
        public static string player1;
        public static string player2;
        public static int[] scoring;

        public static void init(string playerOne, string playerTwo)
        {
            player1 = playerOne;
            player2 = playerTwo;
            scoring = new int[]{ 0, 0 };
        }

        public static void addPoint(string player)
        {
            if (player == player1) scoring[0] += 1;
            if (player == player2) scoring[1] += 1;
        }

        public static string score()
        {
            if(scoring[0] == 0 && scoring[1] == 0) return "score:Love-Love";
            if (scoring[0] == 2 && scoring[1] == 0) return "score:Thirty-Love";
            return "score:Fifteen-Love";
        }
    }
}
