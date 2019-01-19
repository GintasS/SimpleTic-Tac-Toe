using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    // Class, that defines a sign option, an option that indicates
    // what player will go first.
    sealed public class SignOption
    {
        // Hold the sign, either an 'O' or an 'X'.
        private char _sign;
        // PictureBox container, that will hold the image.
        private PictureBox _container;

        // Properties.
        public PictureBox Container
        {
            get { return _container; }
            set { _container = value; }
        }

        public char Sign
        {
            get { return _sign; }
            set { _sign = value; }
        }
        
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="sign">Default sign.</param>
        /// <param name="image">Default image.</param>
        public SignOption(char sign, PictureBox image)
        {
            _sign = sign;
            _container = image;
        }

        /// <summary>
        /// Method, that enables/disables the PictureBox container.
        /// </summary>
        /// <param name="state">Bool value to apply for a PictureBox container.</param>
        public void ChangeOptionState(bool state)
        {
            _container.Enabled = state;
        }

        /// <summary>
        /// Method, that swaps all the data with another sign option.
        /// </summary>
        /// <param name="second">Sign option to swap with.</param>
        public void SwapLocation(SignOption second)
        {
            if (_container.Enabled && second != null)
            {
                char signTemp = _sign;
                Point temp = _container.Location;
                PictureBox boxContainer = _container;

                _container.Location = second._container.Location;
                _sign = second.Sign;
                _container = second.Container;

                second._container.Location = temp;
                second.Sign = signTemp;
                second.Container = boxContainer;
            }
        }



    }
}
