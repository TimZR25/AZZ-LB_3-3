using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Models.Obstacles
{
    public abstract class Obstacle : IObstacle
    {
        public EventHandler<IUnit> OnDead { get; set; }
        public ICell? CellParent { get; set; }

        public void ApplyDamage(decimal damageAmount)
        {
            throw new NotImplementedException();
        }

        public void ApplyHealth(decimal healthAmount)
        {
            throw new NotImplementedException();
        }

        public void Die()
        {
            throw new NotImplementedException();
        }

        public abstract string GetSign();
    }
}
