using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    public abstract class Cell
    {
        public abstract bool isAlive();
    }
}
