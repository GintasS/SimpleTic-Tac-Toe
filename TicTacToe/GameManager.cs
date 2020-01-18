using System.Linq;
using System.Windows.Forms;
using TicTacToe.Models;

namespace TicTacToe
{
    // Main class, that will handle whole game.
    public static class GameManager
    {
        public static Tile[] Board { get; set; }
        public static Player[] Players { get; set; }
        public static int CurrentPlayerIndex { get; set; }
        public static string CurrentGamemode => Form1.Tabs.SelectedTab.Text.ToString();   

        private static bool GameWasTied;
        private static bool GameWasWon;

        public static bool IsGameEnded()
        {
            // If we game is finished already, skip the checking.
            if (GameWasTied || GameWasWon)
            {
                return true;
            }

            if (IsGameWon())
            {
                Players[CurrentPlayerIndex].Congratulate();

                GameWasWon = true;
                Form1.GameArea.Enabled = false;
            }
            else if (IsGameTied())
            {
                MessageBox.Show(Constants.GameState.Tie);

                GameWasTied = true;
                Form1.GameArea.Enabled = false;
            }

            return GameWasTied || GameWasWon;
        }


        private static bool IsGameTied()
        {
            return Board.Count(x => x.IsTileEnabled == false) == Constants.Tile.TotalTiles;
        }

        private static bool IsGameWon()
        {
            char player1Sign = Players[Constants.Index.Player1].Sign;
            char player2Sign = Players[Constants.Index.Player2].Sign;

            foreach (int[] item in Constants.GameState.WinConditions)
            {
                char sign1 = Board[item[0]].Sign;
                char sign2 = Board[item[1]].Sign;
                char sign3 = Board[item[2]].Sign;

                if (sign1 == sign2 && sign1 == sign3)
                {
                    if (sign1 == Constants.Sign.Default)
                    {
                        continue;
                    }
                    else if (player1Sign == sign1 || player2Sign == sign1)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        public static void DetermineFirstTurn()
        {
            var player1 = Players[Constants.Index.Player1].Sign;
            var player2 = Players[Constants.Index.Player2].Sign;

            if (player1 == Constants.Sign.Oh)
            {
                CurrentPlayerIndex = Constants.Index.Player1;
            }
            else if (player2 == Constants.Sign.Oh)
            { 
                CurrentPlayerIndex = Constants.Index.Player2;
            }
        }

        // Swap player index based on a current player.
        public static void DeterminePlayerTurn()
        {
            if (CurrentPlayerIndex == Constants.Index.Player1)
            {
                CurrentPlayerIndex = Constants.Index.Player2;
            }
            else if (CurrentPlayerIndex == Constants.Index.Player2)
            {
                CurrentPlayerIndex = Constants.Index.Player1;
            }
        }



    }
}