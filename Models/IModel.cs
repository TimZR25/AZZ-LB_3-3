using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IModel
    {
        public event EventHandler<IUnit> OnDead;
        public ICell? CellParent { get; set; }
        public void ApplyDamage(decimal damageAmount);
        public void ApplyHealth(decimal healthAmount);
        public void Die();
    }
}
