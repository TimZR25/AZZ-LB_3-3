﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities
{
    public interface IPassiveAbility : IAbility
    {
        public void Execute();
        public IUnit Unit { get; set; }
    }
}
