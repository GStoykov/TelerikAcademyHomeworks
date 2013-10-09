using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _11.Falling_rocks
{
    class Game
    {
        List<Rock> rocks;
        Dwarf dwarf;
        Random rng;
        Stopwatch sw;
        string[] models = {"^", "@", "*", "&", "+", "%", "$", "#", "!", ".", ";" }; 

        public Game()
        {
            sw = new Stopwatch();
            rocks = new List<Rock>();
            dwarf = new Dwarf();
            rng = new Random();
              // 10

        }

        public void MainLoop()
        {
            sw.Start();
            do
            {
                Score();
                Collision();
                GetInput();
                SpawnRocks();
                DrawRocks();
                DrawDwarf();
                                
                Thread.Sleep(150);
            } while (true);
        }

        private void DrawDwarf()
        {
            dwarf.DrawDwarf();

        }

        private void SpawnRocks()
        {
            int rocksOnLine = rng.Next(2, 6);
            for (int i = 0; i < rocksOnLine; i++)
            {
                rocks.Add(new Rock(models[rng.Next(0,11)], rng.Next(0, 80)));
            }

        }

        

        public void DrawRocks()
        {
            MoveDown();
            if (rocks.Count > 0)
            {

                foreach (var rock in rocks)
                {
                    Console.SetCursorPosition(rock.x, rock.prevY);
                    Console.Write(" ");
                    if (rock.y <= 23)
                    {
                        Console.SetCursorPosition(rock.x, rock.y);
                        Console.Write(rock.model);
                    }
                }
            }
        }

        public void Score()
        {

            //Console.SetCursorPosition(0, 0);
            //Console.Write(sw.Elapsed);
            
        }

        public void GetInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x > 0)
                    {
                        dwarf.prevX = dwarf.x;
                        dwarf.x--;
                    }
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x < 70)
	                {
		                dwarf.prevX = dwarf.x;
                        dwarf.x++;
	                }
                    
                }
            }

            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }
        }

        public void Collision()
        {
            foreach (var rock in rocks)
            {
                if (rock.x == dwarf.x && rock.y == dwarf.y)
                {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 2);
                    Console.Write("You survived: {0}", sw.Elapsed);
                    Console.WriteLine();

                    Environment.Exit(0);
                }
            }
        }

        public void MoveDown()
        {

            if (rocks.Count > 0)
            {
                for (int i = 0; i < rocks.Count; i++)
                {
                    if (rocks[i].y < 22)
                    {
                        rocks[i].prevY = rocks[i].y;
                        rocks[i].y += 1;
                    }
                    else
                    {
                        rocks[i].ClearRock();
                        rocks.Remove(rocks[i]);
                    }
                }
            }
        }
    }
}
