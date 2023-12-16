using AZZ_LB_3_3.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IUnit : IModel
    {
        public IUnitStats Stats { get; set; }
        public void UseActiveAbility(IActiveAbility ability, ICell cell);
        public bool TryMove(ICell cell, IField field);

        public event EventHandler OnTurnCompleted;
        public void SkipTurn();
    }
}