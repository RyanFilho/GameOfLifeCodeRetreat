using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public List<Position> Neighbors()
        {
            List<Position> neighbors = new List<Position>();

            neighbors.Add(new Position(X - 1, Y - 1));
            neighbors.Add(new Position(X, Y - 1));
            neighbors.Add(new Position(X + 1, Y - 1));
            neighbors.Add(new Position(X - 1, Y));
            neighbors.Add(new Position(X + 1, Y));
            neighbors.Add(new Position(X - 1, Y + 1));
            neighbors.Add(new Position(X, Y + 1));
            neighbors.Add(new Position(X + 1, Y + 1));

            return neighbors;
        }
    }
}
