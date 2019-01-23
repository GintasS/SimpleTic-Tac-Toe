using System.Drawing;

namespace TicTacToe
{
    // Class, that holds all unique player data.
    sealed public class PlayerClass
    {
        // Player name.
        // Player sign.
        // Player image.
        private string _name;
        private char _sign;
        private Image _signImage;

        // Properties.
        public string Name { get => _name; }        
        public char Sign { get => _sign; }
        public Image SignImage { get => _signImage; }

        public PlayerClass(string playerName, char playerSign,
            Image playerImage)
        {
            _name = playerName;
            _sign = playerSign;
            _signImage = playerImage;
        }
        
    }
}
