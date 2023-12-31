﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IField
    {
        public void AddUnit(IUnit model, int x, int y);
        public void AddObstacle(IObstacle model, int x, int y);
        public void ClearField();

        public List<ICell> GetNeighborsRadius(ICell cell, int radius);
    }
}
