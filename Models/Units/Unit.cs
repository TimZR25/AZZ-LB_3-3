using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public abstract class Unit : IModel
    {
        protected string? _name;

        protected int _maxHealth;

        protected int _health;

        protected int _armor;

        public string? Description { get; protected set; }

        protected int _distanceOfMove;
        protected int _initiative;

        protected int _score;

        protected string? _playerName;

        protected List<IAbility>? _passiveAbilities;
        protected List<IAbility>? _activeAbilities;

        public Cell? CellParent { get; set; }

        public abstract void UseAbility(IAbility ability);

        public bool TryMove(Cell? cell) //добавить условие с дистанцией
        {
            if (cell?.Model != null) return false;

            CellParent?.ClearModelInCell();
            cell?.AddModelInCell(this);

            return true;
        }

        public abstract void ApplyDamage(float amount);

        public void Die() { } // доделать

        public abstract string GetSign();
    }
}
