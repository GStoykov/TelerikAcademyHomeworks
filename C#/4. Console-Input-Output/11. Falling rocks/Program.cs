using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _11.Falling_rocks
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleUtils.CenterConsole();
            Console.SetWindowSize(81, 23);
            Console.SetBufferSize(81, 23);
            Console.CursorVisible = false;

            Game game = new Game();
            game.MainLoop();
            
        }
    }
}
