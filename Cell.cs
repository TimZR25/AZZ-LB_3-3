﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    class Cell
    {
        int x;

        int y;

        bool isEmpty = true;

        string sign = "0";
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return sign + " ";
        }
    }
}
