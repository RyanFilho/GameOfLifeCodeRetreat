using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class Place
    {
        public Position PlacePosition { get; set; }
        public Cell PlacedCell { get; set; }

        public Place(Position position, bool liveOrDeadCell)
        {
            PlacePosition = position;
            if (liveOrDeadCell)
            {
                PlacedCell = new LiveCell();
            }
            else
            {
                PlacedCell = new DeadCell();
            }
        }

        public bool LiveOrDie(int liveNeighbors)
        {
            return PlacedCell.live(liveNeighbors);
        }

        public bool HasLivingCell()
        {
            if (PlacedCell is LiveCell)
                return true;
            return false;
        }

        public void InsertDeadCell()
        {
            PlacedCell = new DeadCell();
        }

        public void InsertLiveCell()
        {
            PlacedCell = new LiveCell();
        }

    }
}
