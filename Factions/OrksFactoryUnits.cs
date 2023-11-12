﻿using AZZ_LB_3_3.Models.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Factions
{
    class OrksFactoryUnits : IAbstractFactoryUnits
    {
        public Unit CreateArcher()
        {
            throw new NotImplementedException();
        }

        public Unit CreateMage()
        {
            throw new NotImplementedException();
        }

        public Unit CreateRider()
        {
            throw new NotImplementedException();
        }

        public Unit CreateWarrior()
        {
            return new OrkLeader();
        }
    }
}