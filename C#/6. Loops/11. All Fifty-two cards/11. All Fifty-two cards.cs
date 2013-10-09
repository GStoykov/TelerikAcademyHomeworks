using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.All_Fifty_two_cards
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). 
            //The cards should be printed with their English names. Use nested for loops and switch-case.
            byte suit;
            string[] number = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven",
                                  "Eight", "Nine", "Ten", "Jack", "Queen", "King"};
            for (int i = 0; i < 13; i++)
            {
                for (byte j = 1; j < 5; j++)
                {
                    suit = j;
                    switch (suit)
                    {
                        case 1: Console.Write("{0} of Spades", number[i]); Console.WriteLine(); break;
                        case 2: Console.Write("{0} of Hearts", number[i]); Console.WriteLine(); break;
                        case 3: Console.Write("{0} of Diamonds", number[i]); Console.WriteLine(); break;
                        case 4: Console.Write("{0} of Clubs", number[i]); Console.WriteLine(); break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
 

        }
    }
}
