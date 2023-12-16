using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.ActiveAbilities
{
    public class FireBall : IActiveAbility
    {
        public string Description { get; set; }
        public int Сost { get ; set; }

        public decimal Multiplier => 5;
        
        public FireBall(int сost) // подумать
        {
            Description = "Огненный шар наносит много урона";
            Сost = сost;
        }

        public decimal Execute(decimal power)
        {
            return -power * Multiplier;
        }
    }
}
