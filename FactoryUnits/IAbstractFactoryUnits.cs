using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    interface IAbstractFactoryUnits
    {
        public Unit CreateWarrior();

        public Unit CreateMage();

        public Unit CreateArcher();

        public Unit CreateRider();
    }
}
