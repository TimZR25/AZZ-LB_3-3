using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.ActiveAbilities
{
    public class Heal: IActiveAbility
    {
        public string Description { get; set; }
        public int Сost { get; set; }

        public decimal Coefficient => 3;

        public Heal(int сost, string description)
        {
            Description = description;
            Сost = сost;
        }

        public decimal Execute(decimal power)
        {
            return power * Coefficient;
        }
    }
}
