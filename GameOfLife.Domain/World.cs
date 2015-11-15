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
            List<Position> neighbors = place.Position.Neighbors();
            int count = 0;
            foreach (var p in Mapa)
            {
                foreach (var n in neighbors)
                {
                    if (p.Position.Equals(n))
                    {
                        count++;
                    }
                }
            }            
            return count;
        }
    }
}
