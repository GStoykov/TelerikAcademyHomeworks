using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Falling_rocks
{
    class Rock
    {
        public int x, y, prevY;
        public string model;

        public Rock(string model, int x)
        {
            y = 0;
            this.model = model;
            this.x = x;
            prevY = y;

        }

        //public void DrawRock()
        //{
        //    if (prevY < 40)
        //    {
        //        Console.SetCursorPosition(x, prevY);
        //        Console.Write(" ");
        //    }

        //    if (y < Console.WindowHeight)
        //    {
        //        Console.SetCursorPosition(x, y);
        //        Console.Write(this.model);
        //    }

        //}

      

        //public bool MoveDown()
        //{
        //    if (y <= Console.WindowHeight)
        //    {
        //        prevY = y;
        //        y++;
        //        return false;
        //    }
        //    return true;
        //}

        public void ClearRock()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
            
        }
    }
}
