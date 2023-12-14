using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class FactoriesUnitsFactory
    {
        public IAbstractFactoryUnits CreateFactory(TypeFaction typeFaction) => typeFaction switch
        {
            TypeFaction.HUMANS => new HumansFactoryUnits(),
            TypeFaction.ORCS => new OrcsFactoryUnits(),
            TypeFaction.UNDEADS => new UndeadsFactoryUnits(),
            _ => throw new NotImplementedException("Такой фабрики не существует"),
        };
    }
}
