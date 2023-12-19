using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities
{
    public interface IActiveAbility: IAbility
    {
        public int Cost { get; set; }
        public decimal Execute(decimal power);
    }
}
