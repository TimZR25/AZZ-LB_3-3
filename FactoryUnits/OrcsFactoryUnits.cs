using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class OrcsFactoryUnits : IAbstractFactoryUnits
    {
        public Unit CreateArcher(IUnitStats unitStats)
        {
            return new OrcArcher(unitStats);
        }

        public Unit CreateMage(IUnitStats unitStats)
        {
            return new OrcMage(unitStats);
        }

        public Unit CreateWarrior(IUnitStats unitStats)
        {
            return new OrcWarrior(unitStats);
        }
    }
}
