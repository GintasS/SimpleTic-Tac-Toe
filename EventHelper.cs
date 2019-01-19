using System;
using System.Windows.Threading;
using System.Windows.Forms;

namespace TicTacToe
{
    // Class, that adds additional functionality to Event class.
    public class EventHelper
    {
        protected GroupBox _boardBox;
        protected Label[] GameModeLabels;
        protected Button _startGameBTN;
        protected Button _resetBTN;
        protected TabControl _tabs;

        // Properties.
        public GroupBox BoardBox
        {
            get { return _boardBox; }
            set { _boardBox = value; }
        }

        public Button StartGameBTN
        {
            get { return _startGameBTN; }
            set { _startGameBTN = value; }
        }

        public Button ResetBTN
        {
            get { return _resetBTN; }
            set { _resetBTN = value; }
        }

        public TabControl Tabs
        {
            get { return _tabs; }
            set { _tabs = value; }
        }

        /// <summary>
        /// Method, that enables/disables sign selectors(PictureBoxes for
        /// selecting a sign).
        /// </summary>
        /// <param name="state">Bool value to apply.</param>
        public void SetStateForSignSelectors(bool state)
        {
            foreach (SignOption item in Form1.GameO.SignOptions)
                item.ChangeOptionState(state);
        }

        /// <summary>
        /// Method, that swaps labels and resets the game.
        /// </summary>
        /// <param name="colIndex">Game mode index.</param>
        protected void SwapGameMode(int colIndex)
        {
            for (int i = 0; i < Form1.Constant.TotalOptions; i++)
                GameModeLabels[i].Text = Form1.Constant.SelectorLabelsText[colIndex][i];

            Form1.GameO.ResetGame();
        }

        /// <summary>
        /// Method, that swaps one selector with another.
        /// </summary>
        protected void SwapSelectors()
        {          
            Form1.GameO.SignOptions[0].SwapLocation(Form1.GameO.SignOptions[1]);
        }

        /// <summary>
        /// Methot, that initalizes player signs right after user clicked on 'Start' button.
        /// </summary>
        protected void SetPlayerSigns()
        {
            string tabName = Tabs.SelectedTab.Text;
            for (int i = 0; i < Form1.Constant.TotalPlayers; i++)
            {
                string playerName = (tabName == Form1.Constant.GameModes[0]) ?
                    Form1.Constant.PossiblePlayers[0][i] : Form1.Constant.PossiblePlayers[1][i];

                Form1.GameO.Players[i] = new Player(
                    playerName,
                    Form1.GameO.SignOptions[i].Sign,
                    Form1.GameO.SignOptions[i].Container.Image
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
        public void DelayAction(int millisecond, Action action)
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
