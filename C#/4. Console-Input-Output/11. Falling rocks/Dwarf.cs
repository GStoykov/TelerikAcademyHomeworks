using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Falling_rocks
{
    class Dwarf
    {
        public string model;
        public int x, y, prevX;

        public Dwarf()
        {
            x = Console.WindowWidth / 2;
            y = Console.WindowHeight - 1;
            model = "O";
            prevX = x;
            
        }

        public void DrawDwarf()
        {
            Console.SetCursorPosition(prevX, y);
            Console.Write(" ");
            Console.SetCursorPosition(x, y);
            Console.Write(this.model);
           
        }

    }
}
