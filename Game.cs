using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // A class that manages game, board tiles and more.
    static public class Game
    {
        // Properties.
           // Game controls, such as buttons, labels and etc.
        public static GroupBox BoardBox { get; set; }
        public static Button StartGameBTN { get; set; }
        public static Button ResetBTN { get; set; }
        public static TabControl Tabs { get; set; }
        public static Label[] GameModeLabels { get; set; }
          // Game logic properties.
        public static PlayerClass[] Players { get; set; }       
        public static SignOption[] SignOptions { get; set; }
        public static List<Tile> BoardTiles { get; set; }
          // Properties for determining.
        public static int TakenBoardTiles { get; set; }
        public static bool GameIsWon { get; set; }
        public static bool GameIsTie { get; set; }

        /// <summary>
        /// Method, that initiates the game board, sets the default values.
        /// </summary>
        /// <param name="containers">PictureBox array to initate.</param>
        public static void InitBoardTiles(PictureBox[] containers)
        {
            // Set the default values and the click event for each tile.
            BoardTiles = new List<Tile>();

            foreach (PictureBox item in containers)
            {
                BoardTiles.Add(new Tile(Constants.Signs[2], item));
                BoardTiles.Last().Container.Click +=
                    EventsClass.PlayerSignEvent;
            }
        }

        /// <summary>
        /// Method, that checks if there are any available tiles to move on.
        /// </summary>
        /// <returns>Bool.</returns>
        public static bool CheckAllTileState()
        {
            if (TakenBoardTiles != Constants.TotalTiles)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method, that checks if someone won the game.
        /// </summary>
        /// <returns>Bool.</returns>
        public static bool CheckWinConditions()
        {
            // Array, that holds all the possible win combinations.
            int[][] winConditions = new int[Constants.WinMovesCount][]
            {
                new int[3] { 0, 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[3] { 6, 7, 8 },
                new int[3] { 0, 3, 6 },
                new int[3] { 1, 4, 7 },
                new int[3] { 2, 5, 8 },
                new int[3] { 0, 4, 8 },
                new int[3] { 2, 4, 6 }
            };

            // Iterate through all win combinations.
            foreach (int[] item in winConditions)
            {
                char sign1 = BoardTiles[item[0]].Sign,
                     sign2 = BoardTiles[item[1]].Sign,
                     sign3 = BoardTiles[item[2]].Sign;

                if (sign1 == sign2 && sign2 == sign3)
                {
                    if (sign1 == Players[0].Sign ||
                        sign1 == Players[1].Sign)
                    {
                        if (sign1 == Players[0].Sign)
                            GameWon(Players[0]);
                        else if (sign1 == Players[1].Sign)
                            GameWon(Players[1]);

                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Method, that checks if players tied the game.
        /// </summary>
        /// <returns>Bool.</returns>
        public static bool CheckTieConditions()
        {
            if (TakenBoardTiles == Constants.TotalTiles)
            {
                GameTie();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method, that congratulates the player for winning the game.
        /// </summary>
        /// <param name="player">Player to contratulate</param>
        private static void GameWon(PlayerClass player)
        {
            if (!GameIsWon)
            {
                MessageBox.Show(
                    player.Name + Constants.States[0],
                    string.Empty, 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                ResetBTN.Enabled = true;
                BoardBox.Enabled = false;
                GameIsWon = true;
            }
        }

        /// <summary>
        /// Method, that tells the users, that no one won(Tie).
        /// </summary>
        private static void GameTie()
        {
            if (!GameIsTie)
            {
                MessageBox.Show(
                    Constants.States[1],
                    string.Empty,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information                   
                );

                ResetBTN.Enabled = true;
                BoardBox.Enabled = false;
                GameIsTie = true;
            }
        }

        /// <summary>
        /// Method, that resets the game.
        /// </summary>
        public static void ResetGame()
        {
            ResetBTN.Enabled = false;
            StartGameBTN.Enabled = true;
            BoardBox.Enabled = false;
            GameIsWon = false;
            GameIsTie = false;
            TakenBoardTiles = 0;

            foreach (Tile item in BoardTiles)
            {
                item.Sign = Constants.Signs[2];
                item.Container.BackColor = Constants.DefaultColor;
                item.Container.Image = null;
                item.Container.Enabled = true;
            }
            EventHelper.SetStateForSignSelectors(true);
            Multiplayer.Reset();
        }

        /// <summary>
        /// Method, that takes a move on a board.
        /// </summary>
        /// <param name="tileIndex">Board tile index.</param>
        /// <param name="playerIndex">Player index that takes the tile.</param>
        public static void TakeMove(int tileIndex, int playerIndex)
        {
            // Take a move.
            BoardTiles[tileIndex].ChangeTile(
                Players[playerIndex].Sign,
                Players[playerIndex].SignImage
            );
            TakenBoardTiles++;

            // Check game conditions.
            if (!CheckWinConditions())
                CheckTieConditions();
        }
    }
}