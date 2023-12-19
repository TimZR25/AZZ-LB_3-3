using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IAbstractFactoryUnits
    {
        public AbstractUnit CreateWarrior(IUnitStats unitStats);

        public AbstractUnit CreateMage(IUnitStats unitStats);

        public AbstractUnit CreateArcher(IUnitStats unitStats);

    }
}
