using System;
using System.Threading;

namespace RTS4X_Game_Project
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            using (var game = new CoreClasses.GameEnviornment())
                game.Run();
        }
    }
#endif
}
