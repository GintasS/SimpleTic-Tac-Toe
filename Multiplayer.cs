namespace TicTacToe
{
    // Class, that handles the multi player part of the game.
    sealed public class Multiplayer
    {

        private bool _player1Turn, 
                     _player2Turn,
                      FirstTurn;

        /// <summary>
        /// Method, for detecting what player will go first.
        /// </summary>
        public void MultiplayerFirstTurn()
        {
            if (FirstTurn == false)
            {
                if (Form1.GameO.Players[0].Sign == Form1.Constant.Signs[0])
                    _player1Turn = true;
                else if (Form1.GameO.Players[1].Sign == Form1.Constant.Signs[0])
                    _player2Turn = true;

                FirstTurn = true;
            }
        }

        /// <summary>
        /// Method, that handles multiplayer move.
        /// </summary>
        /// <param name="index">Move index to take.</param>
        public void MultiPlayerTurn(int index)
        {
            // Detect whose turn it is.
            if (_player1Turn)
            {
                Form1.GameO.TakeMove(index, 0);
                _player1Turn = false;
                _player2Turn = true;
            }
            else if (_player2Turn)
            {
                Form1.GameO.TakeMove(index, 1);
                _player2Turn = false;
                _player1Turn = true;
            }
        }

        /// <summary>
        /// Reset multiplayer values for a new game.
        /// </summary>
        public void MultiPlayerReset()
        {
            _player1Turn = false;
            _player2Turn = false;
            FirstTurn = false;
        }



    }
}
