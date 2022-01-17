using System;

namespace Tennis
{
    public class Kata
    {
        public static string player1;
        public static string player2;
        public static int[] score;

        public static void init(string playerOne, string playerTwo)
        {
            player1 = playerOne;
            player2 = playerTwo;
            score = new int[]{ 0, 0 };
        }

        public static void addPoint(string player)
        {
            if (player == player1) score[0] += 1;
            if (player == player2) score[1] += 1;
        }
    }
}
