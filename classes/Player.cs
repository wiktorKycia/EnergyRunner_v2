using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner_v2.classes
{
    enum Direction
    {
        Up, Right, Down, Left
    }

    internal class Player : BoardObject
    {
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }

        public Player()
        {
            PositionX = 0;
            PositionY = 0;
        }

        public void Move(Direction direction)
        {
            switch ((int)direction)
            {
                case 1:
                    PositionY--;
                    break;
                case 2:
                    PositionX++;
                    break;
                case 3:
                    PositionY++;
                    break;
                case 4:
                    PositionX--;
                    break;
                default:
                    throw new Exception("Something went wrong, probably you tried to move in an unknown directoin");
            }
        }
    }
}
