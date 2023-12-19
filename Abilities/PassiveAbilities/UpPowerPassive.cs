using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.PassiveAbilities
{
    public class UpPowerPassive : IPassiveAbility
    {
        public string Description { get; set; }

        public decimal Coefficient => (decimal)1.1;

        public IUnit Unit { get; set; }

        public UpPowerPassive(IUnit unit, string description)
        {
            Unit = unit;
            Description = description;
        }

        public void Execute()
        {
            Unit.Stats.Power = Unit.Stats.Power * Coefficient;
        }
    }
}
