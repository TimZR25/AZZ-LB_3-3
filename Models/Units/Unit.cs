﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Models.Units
{
    public class Unit : AbstractUnit
    {
        public Unit(IUnitStats unitStats) {
            Stats = unitStats;
        }
    }
}
