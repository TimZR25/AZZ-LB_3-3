using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Models.Units
{
    public class OrcMage: Unit
    {
        public OrcMage() 
        {
            Description = "Орк маг колдует заклинания";
        }
        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OM";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
