using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Models.Units
{
    public class OrcArcher: Unit
    {
        public OrcArcher()
        {
            Description = "Орк лучник стреляет из тяжелого лука";
        }
        public override void ApplyDamage(float amount)
        {
            throw new NotImplementedException();
        }

        public override string GetSign()
        {
            return "OA";
        }

        public override void UseAbility(IAbility ability)
        {
            throw new NotImplementedException();
        }
    }
}
