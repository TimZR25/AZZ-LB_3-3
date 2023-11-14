using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class OrcsFactoryUnits : IAbstractFactoryUnits
    {
        public Unit CreateArcher()
        {
            return new OrcArcher();
        }

        public Unit CreateMage()
        {
            return new OrcMage();
        }

        public Unit CreateRider()
        {
            return new OrcRider();
        }

        public Unit CreateWarrior()
        {
            return new OrcWarrior();
        }
    }
}
