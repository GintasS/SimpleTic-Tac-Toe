using System;

namespace TicTacToe
{
    // Class, that handles all the singleplayer part of the game.
    sealed public class Singleplayer : Computer
    {
        /// <summary>
        /// Method, that starts single player game if the computer goes first.
        /// </summary>
        public void StartSinglePlayerGame()
        {
            if (Form1.GameO.Players[0].Sign == Form1.Constant.Signs[0])
                EducatedComputerMove();
        }

        /// <summary>
        /// Method, that generates a computer move.
        /// </summary>
        public void EducatedComputerMove()
        {
            // Re-enable all the buttons and the board box.
            Form1.AllEvents.BoardBox.Enabled = true;
            Form1.AllEvents.ResetBTN.Enabled = true;
            Form1.AllEvents.Tabs.Enabled = true;

            // If (1;1) coordinate is available, take it.
            if (Form1.GameO.ReturnTileState(FirstCompMove))
            {
                Form1.GameO.TakeMove(
                    FirstCompMove,
                    Form1.Constant.Player1Index
                );
            }
            else
            {
                // Else generate a educated move in order to win
                // or make a random move.
                int index = CheckComputerMoves();

                if (index == -1)
                    RandomComputerMove();
                else if (Form1.GameO.ReturnTileState(index))
                    Form1.GameO.TakeMove(index, Form1.Constant.Player1Index);
            }           
        }

        /// <summary>
        /// Method, that generates a random computer move.
        /// </summary>
        private void RandomComputerMove()
        {
            // If there are tiles to move on, proceed.
            bool availableTiles = Form1.GameO.CheckAllTileState();

            while (availableTiles)
            {
                Random rnd = new Random();
                int move = rnd.Next(0, Form1.Constant.TotalTiles);

                if (Form1.GameO.ReturnTileState(move))
                {
                    Form1.GameO.TakeMove(move, Form1.Constant.Player1Index);
                    break;
                }
            }
        }
       


    }
}