using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.PassiveAbilities
{
    public class UpEnergy : IPassiveAbility
    {
        public string Description { get; set; }

        public decimal Coefficient => (decimal)0.05;

        public IUnit Unit { get; set; }

        public UpEnergy(IUnit unit, string description)
        {
            Unit = unit;
            Description = description;
        }

        public void Execute()
        {
            if (Unit.Stats.MaxEnergy >= Unit.Stats.CurrentEnergy + Unit.Stats.MaxEnergy * Coefficient) { Unit.Stats.CurrentEnergy = Unit.Stats.MaxEnergy; }
            else { Unit.Stats.CurrentEnergy += Unit.Stats.MaxEnergy * Coefficient; }
        }
    }
}
