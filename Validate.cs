using System;

namespace TicTacToe
{
    sealed public class Validate
    {
        private const string Exception1 = " array must have a length of 2!",
                             Exception2 = " - tile index is out of bounds!",
                             Exception3 = " - player index is out of bounds!";

        /// <summary>
        /// Method, that validates array length.
        /// </summary>
        /// <param name="length">Array length.</param>
        /// <param name="value">Array object.</param>
        /// <param name="validationLength">>Array length to validate</param>
        public void ArrayLength(int length, Object value, 
            int validationLength)
        {
            if (length != validationLength)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(value)}" + Exception1);
        }

        /// <summary>
        /// Method, that validates if the tile index is valid.
        /// </summary>
        /// <param name="index">Tile index to validate.</param>
        public void TileIndex(int index)
        {           
            if (index < Form1.Constant.TileIndexLower || 
                index > Form1.Constant.TileIndexUpper)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(index)}" + Exception2);

        }

        /// <summary>
        /// Method, that validates if player index is valid.
        /// </summary>
        /// <param name="index">Player index to validate.</param>
        public void PlayerIndex(int index)
        {
            if (index != Form1.Constant.Player1Index &&
                index != Form1.Constant.Player2Index)
                throw new ArgumentOutOfRangeException(
                    $"{nameof(index)}" + Exception3);
        }
    }
}