using System;
using System.Windows.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    // Class, that adds additional functionality to Event class.
    static class EventHelper
    {
        /// <summary>
        /// Method, that enables/disables sign selectors(PictureBoxes for
        /// selecting a sign).
        /// </summary>
        /// <param name="state">Bool value to apply.</param>
        public static void SetStateForSignSelectors(bool state)
        {
            foreach (SignOption item in Game.SignOptions)
                item.Container.Enabled = state;
        }

        /// <summary>
        /// Method, that swaps labels and resets the game.
        /// </summary>
        /// <param name="colIndex">Game mode index.</param>
        public static void SwapGameMode(int colIndex)
        {
            for (int i = 0; i < Constants.TotalOptions; i++)
                Game.GameModeLabels[i].Text = Constants.Players[colIndex][i];

            Game.ResetGame();
        }

        /// <summary>
        /// Method, that swaps one selector with another.
        /// </summary>
        public static void SwapSelectors() =>          
            Game.SignOptions[0].SwapLocation(Game.SignOptions[1]);

        /// <summary>
        /// Methot, that initalizes player signs right after user clicked on 'Start' button.
        /// </summary>
        public static void SetPlayerSigns()
        {
            string tabName = Game.Tabs.SelectedTab.Text;
            for (int i = 0; i < Constants.TotalPlayers; i++)
            {
                string playerName = (tabName == Constants.GameModes[0]) ?
                    Constants.Players[0][i] : Constants.Players[1][i];

                Game.Players[i] = new PlayerClass(
                    playerName,
                    Game.SignOptions[i].Sign,
                    Game.SignOptions[i].Container.Image
                );
            }
        }

        // Code from:
        // https://stackoverflow.com/questions/10458118/wait-one-second-in-running-program

        /// <summary>
        /// Methoh, that delays action.
        /// </summary>
        /// <param name="millisecond">Time in milliseconds to wait.</param>
        /// <param name="action">Action to complete.</param>
        public static void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate
            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }
    }
}