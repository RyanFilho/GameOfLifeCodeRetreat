﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Domain
{
    class DeadCell : Cell
    {
        public override bool isAlive()
        {
            throw new NotImplementedException();
        }
    }
}