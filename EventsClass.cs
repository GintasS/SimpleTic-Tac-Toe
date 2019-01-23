using System;
using System.Windows.Forms;

namespace TicTacToe
{
    /* Class, that handles user click events from controls, such as buttons or
       PictureBoxes.*/                                              
    static class EventsClass
    {  
        /// <summary>
        /// Method, responsible for handling user click 
        /// event on any board tile(PictureBox). 
        /// </summary>
        public static void PlayerSignEvent(object sender, EventArgs e)
        {
            // Int index saves the number of PictureBox that was
            // clicked.
            PictureBox container = sender as PictureBox;
            int index = 0;
            Int32.TryParse(container.Tag.ToString(), out index);

            // Check for current game mode.
            if (Game.Tabs.SelectedTab.Text == Constants.GameModes[0])
            {
                // Single player, meaning we need to deal with the computer turns.                
                // Take a User move, then disable the board and two buttons
                // and delay computer move for X milliseconds.
                Game.TakeMove(index, 1);

                if (!Game.GameIsTie && !Game.GameIsWon)
                {
                    Game.BoardBox.Enabled = false;
                    EventHelper.DelayAction(
                        Constants.SleepAfterTurn,
                        Computer.MoveManager
                    );
                }
            }
            else if (Game.Tabs.SelectedTab.Text == Constants.GameModes[1])
            {
                // Multi player.
                Multiplayer.DetectWhoGoesFirst();
                Multiplayer.TurnManager(index);
            }
            
        }

        /// <summary>
        /// Method, that handles 'Start' button click event.
        /// </summary>
        public static void StartGameEvent(object sender, EventArgs e)
        {
            Game.StartGameBTN.Enabled = false;
            Game.ResetBTN.Enabled = false;
            EventHelper.SetStateForSignSelectors(false);

            EventHelper.SetPlayerSigns();

            if (Game.Tabs.SelectedTab.Text == Constants.GameModes[0])
            {
                if (Game.Players[0].Sign == Constants.Signs[0])
                {
                    Game.BoardBox.Enabled = false;

                    EventHelper.DelayAction(
                        Constants.SleepAfterTurn,
                        Computer.MoveManager
                    );
                }
                else
                    Game.BoardBox.Enabled = true;
            }
            else
                Game.BoardBox.Enabled = true;
        }

        /// <summary>
        /// Method, that handles 'Reset' button click event.
        /// It resets all the data needed to start a new game.
        /// </summary>
        public static void ResetGameEvent(object sender, EventArgs e) =>
            Game.ResetGame();

        /// <summary>
        /// Method, that handles a swap of a game mode event.
        /// </summary>
        public static void SwapGameModeEvent(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Text == Constants.GameModes[0])
                EventHelper.SwapGameMode(0);
            else if (e.TabPage.Text == Constants.GameModes[1])
                EventHelper.SwapGameMode(1);
        }

        /// <summary>
        /// Method, that swaps the signs.
        /// </summary>
        public static void SelectSignEvent(object sender, EventArgs e) =>
            EventHelper.SwapSelectors();    
    }
}