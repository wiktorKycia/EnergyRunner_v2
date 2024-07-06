using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergyRunner_v2.classes
{
    internal abstract class BoardObject
    {
        public abstract int PositionX { get; set; }
        public abstract int PositionY { get; set; }
    }
}
