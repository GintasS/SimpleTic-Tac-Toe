using System.Drawing;

namespace TicTacToe
{
    // Class, that defines almost all the constants used for the game.
    static class Constants
    {
        // Game modes of the tic tac toe.
        public static readonly string[] GameModes =
        {
            "Single Player", "Multi Player"
        };

        // Possible signs of tic tac toe players.
        public static readonly char[] Signs =
        {
            'O', 'X', '-'
        };

        // Player names on different game modes.
        public static readonly string[][] Players =
        {
            new string[] { "Computer", "Player" },
            new string[] { "Player 1", "Player 2" }
        };

        // Game states that we are going to display back
        // to the user.
        public static readonly string[] States =
        {
            " won!", "A Tie!"
        };

        // Const values for array initialization.
        public const int WinMovesCount = 8,
                         CompMovesCount = 24;

        // Properties.
           // General.
        public static int TotalTiles { get => 9; }
        public static int TotalOptions { get => 2; }
        public static int TotalPlayers { get => 2; }
        public static int Player1Index { get => 0; }
        public static int Player2Index { get => 1; }
        public static int TileIndexLower { get => 0; }
        public static int TileIndexUpper { get => 8; }
        public static int SleepAfterTurn { get => 900; }
        public static Color DefaultColor { get => Color.WhiteSmoke; }
             // Computer turns.
        public static int ComputerChanceTotal { get => 100; }
        public static int ComputerChanceToBadMove { get => 30; }
        public static int FirstCompMove { get => 4; }
    }   
}