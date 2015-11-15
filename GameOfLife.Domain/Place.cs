using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class Place
    {
        public Position Position { get; set; }
        public Cell Cell { get; set; }

        public Place(Position position, Cell cell)
        {
            Position = position;
            Cell = cell;
        }

        public void LiveOrDie(int liveNeighbors)
        {
            if (Cell.live(liveNeighbors))
                Cell = new LiveCell();
            else
                Cell = new DeadCell();
        }


    }
}
