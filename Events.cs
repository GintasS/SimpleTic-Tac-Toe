using System;
using System.Windows.Forms;

namespace TicTacToe
{
    /* Class, that handles user click events from controls, such as buttons or
     * PictureBoxes.
    */                                              
    sealed public class Events : EventHelper
    {     
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="boardBox">Board.</param>
        /// <param name="playerLabels">Player labels.</param>
        /// <param name="buttons">All buttons.</param>
        /// <param name="tabs">ALl tabs.</param>
        public Events(GroupBox boardBox, Label[] playerLabels, 
            Button[] buttons, TabControl tabs)
        {               
            // Validate arrays.
            Form1.Validation.ArrayLength(
                playerLabels.Length, 
                playerLabels, 
                2
            );

            Form1.Validation.ArrayLength(
                buttons.Length,
                buttons,
                2
            );
            
            // Set values for a game.
            _boardBox = boardBox;
            GameModeLabels = playerLabels;
            
            _startGameBTN = buttons[0];
            _resetBTN = buttons[1];
            _resetBTN.Enabled = false;
            _tabs = tabs;
            _boardBox.Enabled = false;          
        }

        /// <summary>
        /// Method, responsible for handling user click event on any board tile(PictureBox). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PlayerSignEvent(object sender, EventArgs e)
        {
            // Int index saves the number of PictureBox that was
            // clicked.
            PictureBox container = sender as PictureBox;
            int index = 0;
            Int32.TryParse(container.Tag.ToString(), out index);

            // Validate that index.
            Form1.Validation.TileIndex(index);

            // Check for current game mode.
            if (_tabs.SelectedTab.Text == Form1.Constant.GameModes[0])
            {
                // Single player, meaning we need to deal with the computer turns.
                
                // Take a User move, then disable the board and two buttons
                // and delay computer move for X milliseconds.
                Form1.GameO.TakeMove(index, 1);
                _boardBox.Enabled = false;
                _resetBTN.Enabled = false;
                _tabs.Enabled = false;

                Form1.AllEvents.DelayAction(Form1.Constant.SleepAfterTurn,
                    Form1.SingleP.EducatedComputerMove);
            }
            else if (_tabs.SelectedTab.Text == Form1.Constant.GameModes[1])
            {
                // Multi player.

                Form1.MultiP.MultiplayerFirstTurn();
                Form1.MultiP.MultiPlayerTurn(index);
            }
            
        }

        /// <summary>
        /// Method, that handles 'Start' button click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void StartGameEvent(object sender, EventArgs e)
        {
            _boardBox.Enabled = true;
            _startGameBTN.Enabled = false;
            _resetBTN.Enabled = true;
            SetStateForSignSelectors(false);

            SetPlayerSigns();

            if (Tabs.SelectedTab.Text == Form1.Constant.GameModes[0])
                Form1.SingleP.StartSinglePlayerGame();
        }

        /// <summary>
        /// Method, that handles 'Reset' button click event.
        /// It resets all the data needed to start a new game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ResetGameEvent(object sender, EventArgs e)
        {
            Form1.GameO.ResetGame();
        }


        /// <summary>
        /// Method, that handles a swap of a game mode event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SwapGameModeEvent(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == Form1.Constant.GameModes[0])
                SwapGameMode(1);
            else if (e.TabPage.Text == Form1.Constant.GameModes[1])
                SwapGameMode(0);
        }

        /// <summary>
        /// Method, that handles the click event of a PictureBox, assosiated with
        /// Player 1 (Single player: Computer).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSign1Event(object sender, EventArgs e)
        {
            SwapSelectors();
        }

        /// <summary>
        /// Method, that handles the click event of a PictureBox, assosiated with
        /// Player  2(Single player: Player). 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectSign2Event(object sender, EventArgs e)
        {
            SwapSelectors();
        }


     
    }
}