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
            InitMockWorld();
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
            bool[] vetor = new bool[Map.Count];
            int count = 0;

            foreach(var p in Map)
            {
                vetor[count] = p.HasLivingCell();
                count++;
            }

            return vetor;
        }

        private void InitMockWorld()
        {
            List<Place> places = new List<Place>();

            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    places.Add(new Place(new Position(i, j), false));

            Map = places;

            InsertLiveCell(new Position(1, 1));
            InsertLiveCell(new Position(2, 2));
            InsertLiveCell(new Position(2, 3));
            InsertLiveCell(new Position(3, 1));
            InsertLiveCell(new Position(3, 2));
        }

        private void InsertDeadCell(Position position)
        {
            foreach (var p in Map)
            {
                if (p.PlacePosition.X == position.X && p.PlacePosition.Y == position.Y)
                    p.InsertDeadCell();
            }
        }

        private void InsertLiveCell(Position position)
        {
            foreach (var p in Map)
            {
                if (p.PlacePosition.X == position.X && p.PlacePosition.Y == position.Y)
                    p.InsertLiveCell();
            }
        }
    }
}
