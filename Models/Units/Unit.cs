using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public abstract class Unit : IUnit
    {
        public IUnitStats UnitStats { get; set; }
        public ICell? CellParent { get; set; }
        public EventHandler<IUnit> OnDead { get; set; }
        public void UseAbility(IActiveAbility ability, ICell cell)
        {
            if (UnitStats.AmountEnergy < ability.Сost) return;

            decimal amount = ability.Execute(UnitStats.Power);

            if (amount < 0) cell.Model.ApplyDamage(amount);
            if (amount > 0) ApplyHealth(amount);
        }

        public bool TryMove(ICell? cell, IField field)
        {
            if (cell?.Model != null) return false;
            
            if (field.GetNeighborsRadius(CellParent, UnitStats.DistanceOfMove).Contains(cell))
            {
                CellParent.Model = null;
                cell.Model = this;

                return true;
            }

            return false;
        }

        public void ApplyDamage(decimal damageAmount)
        {
            decimal multiplier = (1 - UnitStats.Armor);
            if (UnitStats.CurrentHealth - (multiplier * damageAmount) <= 0)
            {
                Die();
                return;
            }

            UnitStats.CurrentHealth -= damageAmount * multiplier;
        }

        public void ApplyHealth(decimal healthAmount)
        {
            if (UnitStats.MaxHealth > UnitStats.CurrentHealth + healthAmount)
            {
                UnitStats.CurrentHealth = UnitStats.MaxHealth;
                return;
            }

            UnitStats.CurrentHealth += healthAmount;
        }

        public void Die()
        {
            CellParent.Model = null;

            OnDead?.Invoke(this, this);
        }

        public abstract string GetSign();
    }
}
