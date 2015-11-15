using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class LiveCell : Cell
    {
        public override bool live(int liveNeighbors)
        {
            if (liveNeighbors == 2 || liveNeighbors == 3)
                return true;
            return false;
        }
    }
}
