using System.Drawing;

namespace TicTacToe
{
    // Class, that holds all unique player data.
    sealed public class Player
    {
        // Player name.
        private readonly string _name;
        // Player sign.
        private readonly char _sign;
        // Player image.
        private readonly Image _signImage;

        // Properties.
        public string Name { get => _name; }        
        public char Sign { get => _sign; }
        public Image SignImage { get => _signImage; }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="playerName">Player name.</param>
        /// <param name="playerSign">Player sign.</param>
        /// <param name="playerImage">Player image.</param>
        public Player(string playerName, char playerSign,
            Image playerImage)
        {
            _name = playerName;
            _sign = playerSign;
            _signImage = playerImage;
        }
        


    }
}
