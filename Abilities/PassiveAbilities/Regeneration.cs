using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.PassiveAbilities
{
    public class Regeneration : IPassiveAbility
    {
        public string Description { get; set; }

        public Regeneration() // подумать
        {
            Description = "Регенерация";
        }

        public decimal Execute(decimal power)
        {
            return power * 2;
        }
    }
}
