using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
            InitEventData();
            SetClickEvents();
         }

        /// <summary>
        /// Method, that initiates all data needed for the game.
        /// </summary>
        private void InitData()
        {
            PictureBox[] Board = new PictureBox[] {
                pictureBox1, pictureBox2, pictureBox3,
                pictureBox4, pictureBox5, pictureBox6,
                pictureBox7, pictureBox8, pictureBox9
            };

            Game.SignOptions = new SignOption[] 
            {
                new SignOption(Constants.Signs[0], pictureBoxSelect1),
                new SignOption(Constants.Signs[1], pictureBoxSelect2)
            };

            Game.Players = new PlayerClass[Constants.TotalPlayers];
            Game.InitBoardTiles(Board);
        }

        /// <summary>
        /// Method, that initiates event data.
        /// </summary>
        private void InitEventData()
        {
            Game.BoardBox = TileParentBox;
            Game.GameModeLabels = new Label[]
            { Player1Name, Player2Name };

            Game.StartGameBTN = StartGameBTN;
            Game.ResetBTN = ResetBTN;
            Game.ResetBTN.Enabled = false;
            Game.Tabs = tabControl1;
        }

        /// <summary>
        /// Method, that sets click events for buttons, tabs.
        /// </summary>
        private void SetClickEvents()
        {
            StartGameBTN.Click += EventsClass.StartGameEvent;
            ResetBTN.Click += EventsClass.ResetGameEvent;
            pictureBoxSelect1.Click += EventsClass.SelectSignEvent;
            pictureBoxSelect2.Click += EventsClass.SelectSignEvent;
            tabControl1.Selected += EventsClass.SwapGameModeEvent;
        }
    }
}