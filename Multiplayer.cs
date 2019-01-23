namespace TicTacToe
{
    // Class, that handles the multi player part of the game.
    static class Multiplayer
    {
        private static bool Player1Turn, 
                            Player2Turn,
                            FirstTurn;

        /// <summary>
        /// Method, for detecting what player will go first.
        /// </summary>
        public static void DetectWhoGoesFirst()
        {
            if (FirstTurn == false)
            {
                if (Game.Players[0].Sign == Constants.Signs[0])
                    Player1Turn = true;
                else if (Game.Players[1].Sign == Constants.Signs[0])
                    Player2Turn = true;

                FirstTurn = true;
            }
        }

        /// <summary>
        /// Method, that handles multiplayer move.
        /// </summary>
        /// <param name="index">Move index to take.</param>
        public static void TurnManager(int index)
        {
            // Detect whose turn it is.
            if (Player1Turn)
            {
                Game.TakeMove(index, 0);
                Player1Turn = false;
                Player2Turn = true;
            }
            else if (Player2Turn)
            {
                Game.TakeMove(index, 1);
                Player2Turn = false;
                Player1Turn = true;
            }
        }

        /// <summary>
        /// Reset multiplayer values for a new game.
        /// </summary>
        public static void Reset()
        {
            Player1Turn = false;
            Player2Turn = false;
            FirstTurn = false;
        }
    }
}