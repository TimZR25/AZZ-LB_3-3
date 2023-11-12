using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Factions
{
    interface IAbstractFactoryUnits
    {
        Unit CreateWarrior();

        Unit CreateMage();

        Unit CreateArcher();

        Unit CreateRider();

        //IHumansFaction CreateHumansFaction();
        //IOrksFaction CreateOrksFaction();
        //IUndeadFaction CreateUndeadFaction();
    }
}
