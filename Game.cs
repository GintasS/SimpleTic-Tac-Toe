using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // A class that manages all the game, board tiles and more.
    sealed public class Game
    {
        // Player data.
        private Player[] _players;
        // Different sign option data.
        private SignOption[] _signOptions;
        // Board data.
        private List<Tile> _boardTiles;

        // How many tiles are taken.
        private int _takenBoardTiles;

        // Bools for checkinf if the game is won
        // or if it's a tie.
        private bool _gameIsWon,
                     _gameIsTie;

        private Image _defaultImage;

        // Properties.
        public Player[] Players
        {
            get { return _players; }
            set { _players = value; }
        }
        
        public  SignOption[] SignOptions
        {
            get { return _signOptions; }
            set { _signOptions = value; }
        }

        public List<Tile> BoardTiles
        {
            get { return _boardTiles; }
            set { _boardTiles = value; }
        }

        public int TakenBoardTiles
        {
            get { return _takenBoardTiles; }
            set { _takenBoardTiles = value; }
        }

        public bool GameIsWon { get => _gameIsWon; }
        public bool GameIsTie { get => _gameIsTie; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Game()
        {
            _boardTiles = new List<Tile>();
            _defaultImage = Properties.Resources.white;
        }

        /// <summary>
        /// Method, that initiates the game board, sets the default values.
        /// </summary>
        /// <param name="containers">PictureBox array to initate.</param>
        public void InitBoardTiles(PictureBox[] containers)
        {    
            // Set the default values and the click event for each tile.
            foreach (PictureBox item in containers)
            {
                _boardTiles.Add(new Tile(Form1.Constant.Signs[2], item));     
                _boardTiles.Last().Container.Click += 
                    Form1.AllEvents.PlayerSignEvent;
            }
        }

        /// <summary>
        /// Method, that returns a tile state for a specific board tile.
        /// </summary>
        /// <param name="index">Board tile index.</param>
        /// <returns>Bool.</returns>
        public bool ReturnTileState(int index)
        {
            Form1.Validation.TileIndex(index);

            return (_boardTiles[index].Container.Enabled) ? true : false;           
        }

        /// <summary>
        /// Method, that checks if there are any available tiles to move on.
        /// </summary>
        /// <returns>Bool.</returns>
        public bool CheckAllTileState()
        {
            if (_takenBoardTiles != Form1.Constant.TotalTiles)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method, that checks if someone won the game.
        /// </summary>
        /// <returns>Bool.</returns>
        public bool CheckWinConditions()
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
                char sign1 = _boardTiles[item[0]].Sign,
                     sign2 = _boardTiles[item[1]].Sign,
                     sign3 = _boardTiles[item[2]].Sign;

                if (sign1 == sign2 && sign2 == sign3)
                {
                    if (sign1 == _players[0].Sign ||
                        sign1 == _players[1].Sign)
                    {
                        if (sign1 == _players[0].Sign)
                            Form1.GameO.GameWon(Form1.GameO.Players[0]);
                        else if (sign1 == _players[1].Sign)
                            Form1.GameO.GameWon(Form1.GameO.Players[1]);

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
        public bool CheckTieConditions()
        {
            if (_takenBoardTiles == Form1.Constant.TotalTiles)
            {
                GameTie();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Method, that congratulates the player for wining the game.
        /// </summary>
        /// <param name="player">Player to contratulate</param>
        private void GameWon(Player player)
        {
            if (!_gameIsWon)
            {
                MessageBox.Show(Form1.Constant.States[0] + player.Name + " !!!");
                _gameIsWon = true;
                DisableGame();
            }
        }

        /// <summary>
        /// Method, that tells the users, that no one won(Tie).
        /// </summary>
        private void GameTie()
        {
            if (!_gameIsTie)
            {
                MessageBox.Show(Form1.Constant.States[1]);
                _gameIsTie = true;
                DisableGame();
            }
        }


        /// <summary>
        /// Method, that disables the board.
        /// </summary>
        private void DisableGame()
        {
            Form1.AllEvents.BoardBox.Enabled = false;
        }


        /// <summary>
        /// Method, that resets the game.
        /// </summary>
        public void ResetGame()
        {
            Form1.AllEvents.ResetBTN.Enabled = false;
            Form1.AllEvents.StartGameBTN.Enabled = true;
            Form1.AllEvents.BoardBox.Enabled = false;
            _gameIsWon = false;
            _gameIsTie = false;
            _takenBoardTiles = 0;

            foreach (Tile item in BoardTiles)
            {
                item.Sign = Form1.Constant.Signs[2];
                item.Container.Image = _defaultImage;
                item.Container.Enabled = true;
            }
            Form1.AllEvents.SetStateForSignSelectors(true);
            Form1.MultiP.MultiPlayerReset();
        }

        /// <summary>
        /// Method, that takes a move on a board.
        /// </summary>
        /// <param name="tileIndex">Board tile index</param>
        /// <param name="playerIndex">Player index that takes the tile.</param>
        public void TakeMove(int tileIndex, int playerIndex)
        {
            // Validate parameter data.
            Form1.Validation.TileIndex(tileIndex);
            Form1.Validation.PlayerIndex(playerIndex);

            // Take a move.
            _boardTiles[tileIndex].ChangeTile(
                _players[playerIndex].Sign,
                _players[playerIndex].SignImage
            );
            _takenBoardTiles++;

            // Check game conditions.
            if (!CheckWinConditions())
                CheckTieConditions();
        }



    }
}