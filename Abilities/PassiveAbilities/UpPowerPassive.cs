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

        public decimal Multiplier => (decimal)1.1;

        public UpPowerPassive() // подумать
        {
            Description = "Повышает мощность раз в N ходов";
        }

        public decimal Execute(decimal power)
        {
            return power * Multiplier;
        }
    }
}
