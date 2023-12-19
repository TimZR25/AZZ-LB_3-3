using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.PassiveAbilities
{
    public class UpArmor : IPassiveAbility
    {
        public IUnit Unit { get; set; }

        public string Description { get; set; }

        public decimal Coefficient => 1;

        public UpArmor(IUnit unit, string description)
        {
            Unit = unit;
            Description = description;
        }

        public void Execute()
        {
            if (Unit.Stats.Armor + Coefficient >= Unit.Stats.MaxArmor) { Unit.Stats.Armor = Unit.Stats.MaxArmor; }
            else { Unit.Stats.Armor = Unit.Stats.Armor + (int)Coefficient; }
        }
    }
}
