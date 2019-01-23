using System;
using System.Windows.Forms;

namespace TicTacToe
{
    // Class, that handles computer moves.
    static class Computer
    { 

        /// <summary>
        /// Method, that takes a computer move.
        /// </summary>
        public static void MoveManager()
        {
            // Re-enable all the buttons and the board box.   
            Game.BoardBox.Enabled = true;
            Game.ResetBTN.Enabled = true;
            Game.Tabs.Enabled = true;

            int turnIndex = -1;
            int firstIndex = Constants.FirstCompMove;

            // If (1;1) coordinate is available, take it.
            if (Game.BoardTiles[firstIndex].ReturnTileState())
                turnIndex = firstIndex;
            else
            {
                // badMove sets if this move is going to
                // be a random one ar an educated one.
                bool badMove = ChanceToBadMove();

                if (badMove)
                    turnIndex = RandomMove();
                else
                {
                    turnIndex = EducatedMove();
                    turnIndex = turnIndex == -1 ? RandomMove() : turnIndex;
                }
            }

            if (turnIndex != -1)
                Game.TakeMove(turnIndex, Constants.Player1Index);
        }

        private static bool ChanceToBadMove()
        {
            Random rnd = new Random();
            int move = rnd.Next(0, Constants.ComputerChanceTotal);

            if (move <= Constants.ComputerChanceToBadMove)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method, that generates a random computer move.
        /// </summary>
        private static int RandomMove()
        {
            // If there are tiles to move on, proceed.
            bool availableTiles = Game.CheckAllTileState();

            while (availableTiles)
            {
                Random rnd = new Random();
                int move = rnd.Next(0, Constants.TotalTiles);

                if (Game.BoardTiles[move].ReturnTileState())
                    return move;
            }
            return -1;
        }

        /// <summary>
        /// Method, that gets the best move for the computer
        /// in order to tie or win.Can lose if player starts
        /// first and he moves on (1;1).
        /// </summary>
        /// <returns>Int.</returns>
        private static int EducatedMove()
        {
            /* All moves to choose from.
            3rd column represents the target index, aka the
            index on whom we are going to move if the first and the middle indexes
            are taken.

            Example:
            0 3 6 
            If 0 and 3 tile indexes are taken, move on the 6 index.
            */
            int[][] allMoves = new int[Constants.CompMovesCount][]
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
                new int[] { 6, 4, 2 },
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

            char computerSign = Game.Players[0].Sign;
            char opponentSign = Game.Players[1].Sign;

            int?[] possibleMoves = new int?[Constants.CompMovesCount];

            // Iterate through the moves.
            for (int y = 0; y < Constants.CompMovesCount; y++)
            {
                char signBase = Game.BoardTiles[allMoves[y][0]].Sign,
                     sign1 = Game.BoardTiles[allMoves[y][1]].Sign,
                     returnSign = Game.BoardTiles[allMoves[y][2]].Sign;

                bool condition = (signBase == computerSign || 
                    signBase == opponentSign) ? true : false;
                bool condition1 = (sign1 == signBase &&
                    returnSign == Constants.Signs[2]) ? true : false;

                if (condition && condition1)
                {
                    if (signBase == computerSign)
                        possibleMoves[0] = allMoves[y][2];
                    else if (signBase == opponentSign)
                        possibleMoves[1] = allMoves[y][2];
                }
            }
            
            // If computer can complete the set,
            // do it, otherwise block the player.
            if (possibleMoves[0].HasValue)
                return possibleMoves[0].Value;
            else if (possibleMoves[1].HasValue)
                return possibleMoves[1].Value;
            else
                return -1;
        }
    }
}