namespace TicTacToe
{
    // Class, that defines almost all the constants used for the game.
    sealed public class Constants
    {
        private readonly string[] _gameModes =
        {
            "Single Player", "Multi Player"
        };

        private readonly char[] _signs =
        {
            'O', 'X', '-'
        };

        private readonly string[][] _possiblePlayers =
        {
            new string[] { "Computer", "Player" },
            new string[] { "Player 1", "Player 2" }
        };

        private readonly string[] _states =
        {
            "Game Won by ", "A Tie!!!"
        };

        private readonly string[][] _selectorLabelsText = {
            new string[] { "Player 1:", "Player 2:" },
            new string[] { "Computer:", "Player:" }
        };

        private const int _totalTiles = 9,
                          _totalOptions = 2,
                          _totalPlayers = 2,
                          _player1Index = 0,
                          _player2Index = 1,
                          _tileIndexLower = 0,
                          _tileIndexUpper = 8,
                          _sleepAfterCompTurn = 900;

        public const int CompMovesCount = 24,
                         WinMovesCount = 8;

        public int TotalTiles { get => _totalTiles; }
        public int TotalOptions { get => _totalOptions; }
        public int TotalPlayers { get => _totalPlayers; }
        public int Player1Index { get => _player1Index; }
        public int Player2Index { get => _player2Index; }
        public int TileIndexLower { get => _tileIndexLower; }
        public int TileIndexUpper { get => _tileIndexUpper; }
        public int SleepAfterTurn { get => _sleepAfterCompTurn; }

        public string[] GameModes { get => _gameModes; }
        public char[] Signs { get => _signs; }
        public string[][] PossiblePlayers { get => _possiblePlayers; }
        public string[] States { get => _states; }
        public string[][] SelectorLabelsText { get => _selectorLabelsText; }
    }   
}