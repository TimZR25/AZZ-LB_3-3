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

        public decimal Multiplier => (decimal)1.2;

        public Regeneration(IUnit unit)
        {
            Unit = unit;
            Description = "Регенерация здоровья каждый ход";
        }

        public void Execute()
        {
            if (Unit.Power * Multiplier + Unit.CurrentHealth > Unit.MaxHealth) { Unit.CurrentHealth = Unit.MaxHealth; }
            else { Unit.CurrentHealth = Unit.Power * Multiplier + Unit.CurrentHealth; }
        }
    }
}
