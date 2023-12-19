using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.PassiveAbilities
{
    public class Regeneration : IPassiveAbility
    {
        public IUnit Unit { get; set; }

        public string Description { get; set; }

        public decimal Coefficient => (decimal)1.2;

        public Regeneration(IUnit unit, string description)
        {
            Unit = unit;
            Description = description;
        }

        public void Execute()
        {
            if (Unit.Stats.Power * Coefficient + Unit.Stats.CurrentHealth >= Unit.Stats.MaxHealth) { Unit.Stats.CurrentHealth = Unit.Stats.MaxHealth; }
            else { Unit.Stats.CurrentHealth = Unit.Stats.Power * Coefficient + Unit.Stats.CurrentHealth; }
        }
    }
}
