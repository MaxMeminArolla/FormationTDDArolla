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
            string result = $"score:{Enum.GetName(typeof(QuirkyScoring), scoring[0] > 3 ? 3 : scoring[0])}-{Enum.GetName(typeof(QuirkyScoring), scoring[1] > 3 ? 3 : scoring[1])}";

            if (scoring[0] >= 3 && scoring[1] >= 3 
                && scoring[0] == scoring[1]) result += " (Deuce)";
            if (scoring[0] >= 3 && scoring[1] >= 3
                && Math.Abs(scoring[0]-scoring[1]) == 1) result += $" (Advantage for {(scoring[0] > scoring[1] ? player1 : player2)})";

            return result;
        }

        enum QuirkyScoring
        {
            Love,
            Fifteen,
            Thirty,
            Forty
        }
    }
}
