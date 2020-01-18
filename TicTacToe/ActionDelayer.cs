using System;
using System.Windows.Threading;

namespace TicTacToe
{
    // Delay action by X milliseconds.
    class ActionDelayer
    {
        public static void Delay(int milliseconds, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate
            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(milliseconds);
            timer.Start();
        }



    }
}