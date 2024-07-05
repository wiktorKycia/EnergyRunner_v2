using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner_v2.classes
{
    internal class Home : BoardObject
    {
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }

        public Home(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }
    }
}
