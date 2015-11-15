using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class World
    {
        public List<Place> Mapa { get; set; }

        public void Next()
        {
            foreach(var place in Mapa)
            {
                int liveNeighbors = CountLiveNeighbors(place);
                place.LiveOrDie(liveNeighbors);
            }
        }

        private int CountLiveNeighbors(Place place)
        {

            return 3;
        }
    }
}
