using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // Class for one board tile.
    sealed public class Tile
    {
        // Tile sign: O or X.
        private char _sign;
        // PictureBox container.
        private PictureBox _container;

        // Properties.
        public PictureBox Container { get => _container; }

        public char Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="tileSign">Tile sign.</param>
        /// <param name="container">PictureBox container.</param>
        public Tile(char tileSign, PictureBox container)
        {
            _sign = tileSign;
            _container = container;         
        }

        /// <summary>
        /// Method, that changes the tile data.
        /// </summary>
        /// <param name="sign">Sign to change.</param>
        /// <param name="image">Image to change.</param>
        public void ChangeTile(char sign, Image image)
        {
            _sign = sign;
            _container.Image = image;
            _container.Enabled = false;
        }



    }
}
