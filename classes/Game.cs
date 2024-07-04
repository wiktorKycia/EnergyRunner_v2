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
        public Game(int size)
        {
            Size = size;
            Board = new int[Size, Size];
            for(int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Board[i, j] = randomizer.Next(-9, 9);
                }
            }
        }

    }
}
