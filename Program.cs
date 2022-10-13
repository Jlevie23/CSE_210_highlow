using System;
using CSE_210_HIGHLOW.Game;


namespace CSE_210_HIGHLOW
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>

        /// Main(string[] args) allows for arguments
        static int Main(string[] args)
        {
            Director director = new Director();
            /// Need to find director class 
            director.StartGame();
            /// returns 0 because we begin with 'static int' as opposed to 'static void'
            return 0;
        }
    }
}
