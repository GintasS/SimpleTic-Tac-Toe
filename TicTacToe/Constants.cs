using System.Collections.Generic;

namespace TicTacToe
{
    // All the hard-coded values we're going to use.
    public struct Constants
    {
        public struct Index
        {
            public static int Player1 = 0;
            public static int Player2 = 1;
        }

        public struct Sign
        {
            public static char Oh = 'O';
            public static char X = 'X';
            public static char Default = '-';
        }

        public struct GameState
        {
            public static string Win = " is a Winner!";
            public static string Tie = "A Tie!";

            public static int[][] WinConditions = new int[][]
            {
                new int[3] { 0, 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[3] { 6, 7, 8 },
                new int[3] { 0, 3, 6 },
                new int[3] { 1, 4, 7 },
                new int[3] { 2, 5, 8 },
                new int[3] { 0, 4, 8 },
                new int[3] { 2, 4, 6 }
            };
        }

        public struct Computer
        {
            public static int FirstMove = 4;
            public static int ChanceStart = 0;
            public static int ChanceTotal = 100;
            public static int ChanceToBadMove = 20;
            public static int SleepBeforeTurn = 900;

            public static int[][] Moves = new int[16][]
            {
                // Columns
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 6, 3, 0 },
                new int[] { 7, 4, 1 },
                new int[] { 8, 5, 2 },
                // Rows
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 2, 1, 0 },
                new int[] { 5, 4, 3 },
                new int[] { 8, 7, 6 },
                // Diagonal
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 },
                new int[] { 8, 4, 0 },
                new int[] { 6, 4, 2 }
            };

            public static int[][] BlockMoves = new int[8][]
            {
                // Block Moves
                new int[] { 0, 6, 3 },
                new int[] { 1, 7, 4 },
                new int[] { 2, 8, 5 },
                new int[] { 0, 2, 1 },
                new int[] { 3, 5, 4 },
                new int[] { 6, 8, 7 },
                new int[] { 0, 8, 4 },
                new int[] { 2, 6, 4 }
            };
        }

        public struct Tile
        {
            public static int TotalTiles = 9;
            public static int StartIndex = 0;
        }

        public struct Gamemode
        {
            public static string Singleplayer = "Single Player";
            public static string Multiplayer = "Multi Player";
        }

        public static readonly Dictionary<string, string[]> Players = new Dictionary<string, string[]>()
        {
            { Gamemode.Singleplayer, new string[] { "Computer", "Player" } },
            { Gamemode.Multiplayer, new string[] { "Player 1", "Player 2" } }
        };



    }   
}