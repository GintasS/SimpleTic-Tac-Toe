using System;

namespace TicTacToe
{
    // Pseudo-random number generator.
    public static class RandomNumberGenerator
    {
        private static readonly Random random = new Random();

        public static int GetNumber(int min, int max)
        {
            return random.Next(min, max);
        }



    }
}