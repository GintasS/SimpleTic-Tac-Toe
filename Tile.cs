using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // Class for one board tile.
    sealed public class Tile
    {
        // Tile sign: O or X.
        // PictureBox container.
        public char Sign { get; set; }
        public PictureBox Container { get; set; }

        public Tile(char tileSign, PictureBox container)
        {
            Sign = tileSign;
            Container = container;         
        }

        /// <summary>
        /// Method, that changes individual tile data.
        /// </summary>
        /// <param name="sign">Sign to change.</param>
        /// <param name="image">Image to change.</param>
        public void ChangeTile(char sign, Image image)
        {
            Sign = sign;
            Container.Image = image;
            Container.Enabled = false;
        }

        /// <summary>
        /// Method, that returns a tile state for a specific board tile.
        /// </summary>
        /// <returns>Bool.</returns>
        public bool ReturnTileState()
        {
            return (this.Container.Enabled)
                ? true : false;
        }
    }
}
