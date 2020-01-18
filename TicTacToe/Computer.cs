namespace TicTacToe
{
    // Class, that will manage computer turns.
    public static class Computer
    {
        public static void TakeComputerTurn()
        {
            // Disable board for the duration of a computer turn.
            Form1.GameArea.Enabled = true;

            int index = GetComputerTurnIndex();
            GameManager.Board[index].SetTile(GameManager.Players[GameManager.CurrentPlayerIndex]);

            if (GameManager.IsGameEnded() == false)
            {
                GameManager.DeterminePlayerTurn();
            }
            
        }

        // Gets an index for a computer to move on.
        private static int GetComputerTurnIndex()
        {
            int firstMove = Constants.Computer.FirstMove;

            // If the middle tile available, take it, else
            // see if this turn is going to be a bad(random) move or an educated one.
            if (GameManager.Board[firstMove].IsTileEnabled == true)
            {
                return firstMove;
            }
            else if (IsBadMove())
            {
                return GenerateRandomMove();
            }

            return GenerateEducatedMove();
        }

        private static int GenerateRandomMove()
        {
            while (true)
            {
                int index = RandomNumberGenerator.GetNumber(Constants.Tile.StartIndex, Constants.Tile.TotalTiles);

                if (GameManager.Board[index].IsTileEnabled == true)
                {
                    return index;
                }
            }
        }

        // Calculate a chance for a bad move to occur.
        private static bool IsBadMove()
        {
            return RandomNumberGenerator.GetNumber(Constants.Computer.ChanceStart, Constants.Computer.ChanceTotal) 
                <= Constants.Computer.ChanceToBadMove;
        }

        // Try to generate an educated move, that will block or try to win the game.
        private static int GenerateEducatedMove()
        {
            int? blockMove = null;

            char computerSign = GameManager.Players[Constants.Index.Player1].Sign;
            char defaultSign = Constants.Sign.Default;

            var computerMoves = Constants.Computer.Moves;

            int length = computerMoves.Length;
            for(int i = 0; i < length;i++)
            {
                char sign1 = GameManager.Board[computerMoves[i][0]].Sign;
                char sign2 = GameManager.Board[computerMoves[i][1]].Sign;
                char sign3 = GameManager.Board[computerMoves[i][2]].Sign;

                if (sign1 == sign2 && sign3 == defaultSign)
                {
                    if (sign1 == computerSign)
                    {
                        return computerMoves[i][2];
                    }

                    blockMove = computerMoves[i][2];
                }
                else if (sign1 == sign3 && sign2 == defaultSign)
                {
                    if (sign1 == computerSign)
                    {
                        return computerMoves[i][1];
                    }

                    blockMove = computerMoves[i][1];
                }
                else if (sign2 == sign3 && sign1 == defaultSign)
                {
                    if (sign2 == computerSign)
                    {
                        return computerMoves[i][0];
                    }

                    blockMove = computerMoves[i][0];
                }
            }

            // Return blocking move (because a win move would'be already returned)
            // or a random move.
            return blockMove ?? GenerateRandomMove();
        }



    }
}