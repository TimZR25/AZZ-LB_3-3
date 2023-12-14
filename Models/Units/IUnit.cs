using AZZ_LB_3_3.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IUnit : IUnitStats, IModel
    {
        public void UseAbility(IActiveAbility ability, ICell cell);
        public bool TryMove(ICell cell, IField field);
    }
}