using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class HumansFactoryUnits : IAbstractFactoryUnits
    {
        public Unit CreateArcher(IUnitStats unitStats)
        {
            return new HumanArcher(unitStats);
        }

        public Unit CreateMage(IUnitStats unitStats)
        {
            return new HumanMage(unitStats);
        }

        public Unit CreateWarrior(IUnitStats unitStats)
        {
            return new HumanWarrior(unitStats);
        }
    }
}
