using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner_v2.classes
{
    internal class Game
    {
        public int Size { get; set; }
        public int[,] Board { get; set; }
        private Random randomizer = new Random();
        public Player Player { get; set; }
        public Home Home { get; set; }
        public Game(int size)
        {
            Size = size;
            Board = new int[Size, Size];
            Player = new Player(size);
            Home = new Home(Size-1, Size-1);
            for(int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Board[i, j] = randomizer.Next(-9, 9);
                }
            }
        }
        // display the gameboard
        /* 
         * player in [0,0]
         * home in [size,size]
         * negative numbers in red (without minus)
         * positive numbers in green
         */
        public void UpdateBoard()
        {
            Board[Player.PositionY, Player.PositionX] = 0;
            Board[Home.PositionY, Home.PositionX] = 0;
        }
        public void DisplayBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (Board[i, j] > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(Board[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (Board[i, j] < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(Math.Abs(Board[i, j]) + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (i == Player.PositionY && j == Player.PositionX)
                        {
                            Console.Write("\u2022 ");
                        }
                        else if (i == Home.PositionY && j == Home.PositionX)
                        {
                            Console.Write("\u2302 ");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Write("  ");
                            Console.ResetColor();
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        public void GiveInstructions()
        {
            Console.WriteLine($"\nYou have {Player.Energy} energy");
            Console.WriteLine("\nYou are \u2022");
            Console.WriteLine("Your goal is to reach \u2302");
            Console.WriteLine("You can move by clicking arrows on your keyboard");
            Console.WriteLine("Green numbers can add you the energy, red numbers can subtract you the energy");
            Console.WriteLine("Good luck!");
        }
    }
}
