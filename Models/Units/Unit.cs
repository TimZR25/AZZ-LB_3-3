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

        //protected Faction _faction;

        protected int _score;

        protected string? _playerName;

        protected List<IAbility>? _passiveAbilities;
        protected List<IAbility>? _activeAbilities;


        public abstract void UseAbility(IAbility ability);

        public void Move(Cell cell) { } //доделать

        public abstract void ApplyDamage(float amount);

        public void Die() { } // доделать

        public abstract string GetSign();
    }
}
