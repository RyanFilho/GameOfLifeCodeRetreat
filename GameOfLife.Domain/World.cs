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
            foreach(var place in Map)
            {
                NewMap = new List<Place>();
                int liveNeighbors = CountLiveNeighbors(place);
                NewMap.Add(new Place(place.PlacePosition, place.LiveOrDie(liveNeighbors)));                
            }
            Map = NewMap;
        }

        private int CountLiveNeighbors(Place place)
        {
            List<Position> neighbors = place.PlacePosition.Neighbors();
            int count = 0;
            foreach (var p in Map)
            {
                foreach (var n in neighbors)
                {
                    if (p.PlacePosition.X == n.X && p.PlacePosition.Y == n.Y && p.PlacedCell is LiveCell)
                        count++;                    
                }
            }            
            return count;
        }

        public bool[] getMapVetor()
        {
            bool[] vetor = new bool[9];
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
            places.Insert(0,new Place(new Position(0, 0), true));
            places.Insert(1, new Place(new Position(0, 1), true));
            places.Insert(2, new Place(new Position(0, 2), false));
            places.Insert(3, new Place(new Position(1, 0), true));
            places.Insert(4, new Place(new Position(1, 1), true));
            places.Insert(5, new Place(new Position(1, 2), false));
            places.Insert(6, new Place(new Position(2, 0), false));
            places.Insert(7, new Place(new Position(2, 1), false));
            places.Insert(8, new Place(new Position(2, 2), false));
            return places;
        }
    }
}
