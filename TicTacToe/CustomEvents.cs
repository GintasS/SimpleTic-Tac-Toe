using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    // All events, that we're going to subscribe to.
    public static class CustomEvents
    {
        public static void StartGameBTN_Click(object sender, EventArgs e)
        {
            Form1.ResetButton.Enabled = true;
            Form1.StartButton.Enabled = false;
            Form1.PlayerSignSwapButton.Enabled = false;
            Form1.Tabs.Enabled = false;

            GameManager.DetermineFirstTurn();

            if (GameManager.CurrentGamemode == Constants.Gamemode.Singleplayer)
            {
                if (GameManager.CurrentPlayerIndex == Constants.Index.Player1)
                {
                    Form1.GameArea.Enabled = false;
                    ActionDelayer.Delay(Constants.Computer.SleepBeforeTurn, Computer.TakeComputerTurn);
                }
                else
                {
                    Form1.GameArea.Enabled = true;
                }
            }
            else
            {
                Form1.GameArea.Enabled = true;
            }
        }

        public static void ResetBTN_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Swap player signs.
        public static void playerSignSwapBox_Click(object sender, EventArgs e)
        {
            int player1 = Constants.Index.Player1;
            int player2 = Constants.Index.Player2;

            GameManager.Players[player1].Swap(GameManager.Players[player2]);
        }

        // Change player names based on a gamemode selected.
        public static void gameControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1.Player1LabelName.Text = Constants.Players[GameManager.CurrentGamemode][0];
            Form1.Player2LabelName.Text = Constants.Players[GameManager.CurrentGamemode][1];
        }

        // When user has clicked on a tile.
        public static void BoardTile_Click(object sender, EventArgs e)
        {
            PictureBox container = sender as PictureBox;
            int index = container.Name.Last() - '0';

            // Take a turn.
            GameManager.Board[index].SetTile(GameManager.Players[GameManager.CurrentPlayerIndex]);

            // If game is active, proceed.
            if (GameManager.IsGameEnded() == false)
            {
                GameManager.DeterminePlayerTurn();

                // If we're having a computer agent.
                if (GameManager.CurrentGamemode == Constants.Gamemode.Singleplayer)
                {
                    Form1.GameArea.Enabled = false;
                    ActionDelayer.Delay(Constants.Computer.SleepBeforeTurn, Computer.TakeComputerTurn);
                }
            }
        }



    }
}