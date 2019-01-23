using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // Class, that defines a sign option, an option that indicates
    // what player will go first.
    sealed public class SignOption
    {
        // Hold the sign, either an 'O' or an 'X'.
        // PictureBox container, that will hold the image.
        public char Sign { get; set; }
        public PictureBox Container { get; set; }

        public SignOption(char sign, PictureBox image)
        {
            Sign = sign;
            Container = image;
        }

        /// <summary>
        /// Method, that swaps all the data with another sign option.
        /// </summary>
        /// <param name="second">Sign option to swap with.</param>
        public void SwapLocation(SignOption second)
        {
            if (Container.Enabled && second != null)
            {
                char signTemp = Sign;
                Point coordTemp = Container.Location;
                PictureBox containerTemp = Container;

                Container.Location = second.Container.Location;
                Sign = second.Sign;
                Container = second.Container;
                
                second.Container.Location = coordTemp;
                second.Sign = signTemp;
                second.Container = containerTemp;
            }
        }
    }
}
