using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private static Game _gameObject;
        private static Validate _validation;
        private static Constants _constant;
        private static Singleplayer _singleP;
        private static Multiplayer _multiP;
        private static Events _events;
     
        public static Game GameO { get => _gameObject; }
        public static Validate Validation { get => _validation; }
        public static Constants Constant { get => _constant; }
        public static Singleplayer SingleP { get => _singleP; } 
        public static Events AllEvents { get =>_events; }
        public static Multiplayer MultiP { get => _multiP; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Method, that loads the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
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

           _validation = new Validate();
            _constant = new Constants();

            _gameObject = new Game();
            _gameObject.SignOptions = new SignOption[] {
                new SignOption(Constant.Signs[0], pictureBoxSelect1),
                new SignOption(Constant.Signs[1], pictureBoxSelect2)
            };

            _gameObject.Players = new Player[Constant.TotalPlayers];

            _events = new Events(
                TileParentBox,
                new Label[] { Player1Name, Player2Name },
                new Button[] { StartGameBTN, ResetBTN },
                tabControl1
            );
            
            _gameObject.InitBoardTiles(Board);

            _singleP = new Singleplayer();
            _multiP = new Multiplayer();
        }

        /// <summary>
        /// Method, that sets click events for buttons, tabs.
        /// </summary>
        private void SetClickEvents()
        {
            StartGameBTN.Click += _events.StartGameEvent;
            ResetBTN.Click += _events.ResetGameEvent;
            pictureBoxSelect1.Click += _events.SelectSign1Event;
            pictureBoxSelect2.Click += _events.SelectSign2Event;
            tabControl1.Selected += _events.SwapGameModeEvent;
        }



    }
}