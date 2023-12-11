using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.ActiveAbilities
{
    public class UpInitiativeActive
    {
        public string Description { get; set; }
        public int Сost { get; set; }

        public UpInitiativeActive(int сost) // подумать
        {
            Description = "Увеличивает инициативу";
            Сost = сost;
        }

        public decimal Execute(decimal power)
        {
            return power * (decimal)1.3;
        }
    }
}
