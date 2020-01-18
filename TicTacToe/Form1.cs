using System;
using System.Windows.Forms;
using TicTacToe.Models;

namespace TicTacToe
{
    public sealed partial class Form1 : Form
    {
        public static GroupBox GameArea { get; private set; }
        public static Button StartButton { get; private set; }
        public static Button ResetButton { get; private set; }
        public static PictureBox PlayerSignSwapButton { get; private set; }
        public static TabControl Tabs { get; private set; }
        public static Label Player1LabelName { get; set; }
        public static Label Player2LabelName { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeControls();
            InitializeData();
            InitializeEvents();
        }

        private void InitializeControls()
        {
            GameArea = TileParentBox;
            StartButton = StartGameBTN;
            ResetButton = ResetBTN;
            Tabs = gameControl;
            Player1LabelName = Player1Name;
            Player2LabelName = Player2Name;
            PlayerSignSwapButton = playerSignSwapBox;
        }

        private void InitializeData()
        {
            // Initialize board.
            GameManager.Board = new Tile[]
            {
                new Tile(pictureBox0),
                new Tile(pictureBox1),
                new Tile(pictureBox2),
                new Tile(pictureBox3),
                new Tile(pictureBox4),
                new Tile(pictureBox5),
                new Tile(pictureBox6),
                new Tile(pictureBox7),
                new Tile(pictureBox8)
            };

            // Initialize players.
            GameManager.Players = new Player[]
            {
                new Player(pictureBoxSelect1, Player1LabelName),
                new Player(pictureBoxSelect2, Player2LabelName)
            };
        }

        private void InitializeEvents()
        {
            StartGameBTN.Click += CustomEvents.StartGameBTN_Click;
            ResetBTN.Click += CustomEvents.ResetBTN_Click;
            PlayerSignSwapButton.Click += CustomEvents.playerSignSwapBox_Click;
            Tabs.SelectedIndexChanged += CustomEvents.gameControl_SelectedIndexChanged;
            
            // Initialize tile cliks for every tile.
            foreach (var tile in GameManager.Board)
            {
                tile.Container.Click += CustomEvents.BoardTile_Click;
            }
        }



    }
}