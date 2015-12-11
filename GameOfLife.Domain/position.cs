using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    public class Position
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

        public override bool Equals(object obj) {
            Position objToCompare = obj as Position;
            if (objToCompare == null)
                return false;

            if (objToCompare.X == this.X && objToCompare.Y == this.Y)
                return true;

            return false;
        }

        public override int GetHashCode() {
            return (this.X.ToString() + this.Y.ToString()).GetHashCode();
        }
    }
}
