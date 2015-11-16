using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    public class World
    {
        private List<Place> Map { get; set; }
        private List<Place> NewMap { get; set; }
        public World()
        {
            Map = MockWorld();
            NewMap = new List<Place>();
        }
        public void Turn()
        {
            NewMap = new List<Place>();
            foreach (var place in Map)
            {
                int liveNeighbors = CountLiveNeighbors(place);
                NewMap.Add(new Place(place.PlacePosition, place.LiveOrDie(liveNeighbors)));                
            }
            Map = NewMap;
        }

        private int CountLiveNeighbors(Place place)
        {
            List<Position> neighbors = place.PlacePosition.Neighbors();
            int count = 0;

            foreach (var n in neighbors)
            {
                if (Map.Exists(m => m.PlacePosition.X == n.X && m.PlacePosition.Y == n.Y && m.PlacedCell is LiveCell))
                    count++;
            }
     
            return count;
        }

        public bool[] getMapVetor()
        {
            bool[] vetor = new bool[100];
            int count = 0;
            foreach(var p in Map)
            {
                vetor[count] = p.HasAliveCell();
                count++;
            }

            return vetor;
        }

        private List<Place> MockWorld()
        {
            List<Place> places = new List<Place>();
            places.Add(new Place(new Position(0, 0), false));
            places.Add(new Place(new Position(0, 1), true));
            places.Add(new Place(new Position(0, 2), false));
            places.Add(new Place(new Position(1, 0), false));
            places.Add(new Place(new Position(1, 1), true));
            places.Add(new Place(new Position(1, 2), false));
            places.Add(new Place(new Position(2, 0), false));
            places.Add(new Place(new Position(2, 1), true));
            places.Add(new Place(new Position(2, 2), false));

            return places;
        }
    }
}
