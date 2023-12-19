using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    class UndeadsFactoryUnits : IAbstractFactoryUnits
    {
        public AbstractUnit CreateArcher(IUnitStats unitStats)
        {
            return new UndeadArcher(unitStats);
        }

        public AbstractUnit CreateMage(IUnitStats unitStats)
        {
            return new UndeadMage(unitStats);
        }

        public AbstractUnit CreateWarrior(IUnitStats unitStats)
        {
            return new UndeadWarrior(unitStats);
        }
    }
}
