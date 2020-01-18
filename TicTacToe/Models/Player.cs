using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Models
{
    // Player model that will hold information about a single player
    // (either a human player or a computer player)
    public class Player
    {
        public char Sign => Container.Tag.ToString()[0];
        public Image SignImage => Container.Image;

        private PictureBox Container;
        // Is to keep reference for a player name when a gamemode changes.
        private Label NameLabel;

        public Player(PictureBox container, Label playerNameLabel)
        {
            Container = container;
            NameLabel = playerNameLabel;
        }

        // Swap player when sign changes.
        public void Swap(Player player)
        {
            var tempImage = (Image)Container.Image.Clone();
            var tempSign = Container.Tag;

            Container.Image = (Image)player.SignImage.Clone();
            Container.Tag = player.Sign;

            player.Container.Image = tempImage;
            player.Container.Tag = tempSign;
        }

        // Congratulate player when he wins the game.
        public void Congratulate()
        {
            MessageBox.Show(NameLabel.Text + Constants.GameState.Win);
        }



    }
}