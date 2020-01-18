using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Models
{
    // Model is responsible for holding single tile information.
    public class Tile
    {
        public PictureBox Container { get; private set; }
        public char Sign => Container.Tag.ToString()[0];
        public bool IsTileEnabled => Container.Enabled;

        public Tile(PictureBox container)
        {
            Container = container;
        }

        // Set tile by player's information.
        public void SetTile(Player player)
        {
            Container.Tag = player.Sign;
            Container.Image = (Image)player.SignImage.Clone();
            Container.Enabled = false;
        }



    }
}