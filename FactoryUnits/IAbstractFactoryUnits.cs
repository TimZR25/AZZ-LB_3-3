using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IAbstractFactoryUnits
    {
        public Unit CreateWarrior(IUnitStats unitStats);

        public Unit CreateMage(IUnitStats unitStats);

        public Unit CreateArcher(IUnitStats unitStats);

    }
}
