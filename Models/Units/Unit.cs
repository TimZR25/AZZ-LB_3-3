using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public abstract class Unit : IUnit
    {
        public string? Name { get; }

        protected decimal _maxHealth;

        protected decimal _health;

        protected decimal Power { get; set; }

        protected int _armor;

        public string? Description { get; protected set; }

        protected int _distanceOfMove;

        public int Initiative { get; set; }

        public int Score { get; }

        public int AmountEnergy { get; set; }

        public string PlayerName { get; set; }

        protected List<IPassiveAbility>? _passiveAbilities;
        protected List<IActiveAbility>? _activeAbilities;

        public ICell? CellParent { get; set; }

        public EventHandler<IUnit> OnDead { get; set; }

        public void UseAbility(IActiveAbility ability, ICell cell)
        {
            if (AmountEnergy < ability.Сost) return;

            decimal amount = ability.Execute(Power);

            if (amount < 0) cell.Model.ApplyDamage(amount);
            if (amount > 0) ApplyHealth(amount);
        }

        public bool TryMove(ICell? cell, IField field)
        {
            if (cell?.Model != null) return false;
            
            if (field.GetNeighborsRadius(CellParent, _distanceOfMove).Contains(cell))
            {
                CellParent?.ClearModelInCell();
                cell?.AddModelInCell(this);

                return true;
            }

            return false;
        }

        public void ApplyDamage(decimal damageAmount)
        {
            decimal multuiplier = (1 - _armor);
            if (_health - (multuiplier * damageAmount) <= 0)
            {
                Die();
                return;
            }

            _health -= damageAmount * multuiplier;
        }

        public void ApplyHealth(decimal healthAmount)
        {
            if (_maxHealth > _health + healthAmount)
            {
                _health = _maxHealth;
                return;
            }

            _health += healthAmount;
        }

        public void Die()
        {
            CellParent?.ClearModelInCell();

            OnDead?.Invoke(this, this);
        }

        public abstract string GetSign();
    }
}
