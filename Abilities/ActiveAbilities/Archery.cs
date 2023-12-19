using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.ActiveAbilities
{
    public class Archery : IActiveAbility
    {
        public decimal Coefficient => 2;
        public string Description { get; set; }
        public int Сost { get; set; }

        public Archery(int сost, string description)
        {
            Description = description;
            Сost = сost;
        }

        public decimal Execute(decimal power)
        {
            return -power * Coefficient;
        }
    }
}
