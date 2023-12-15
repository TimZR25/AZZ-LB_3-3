using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public abstract class Unit : IUnit
    {
        public decimal CurrentHealth { get; set; }
        public decimal Power { get; set; }
        public int Armor { get; set; }
        public string Description { get; set; }
        public int DistanceOfMove { get; set; }
        public int Initiative { get; set; }
        public int AmountEnergy { get; set; }



        protected List<IPassiveAbility>? _passiveAbilities;
        protected List<IActiveAbility>? _activeAbilities;

        public ICell? CellParent { get; set; }

        public EventHandler<IUnit> OnDead { get; set; }

        public event EventHandler OnTurnCompleted;

        private bool isMoved = false;

        public string Name => throw new NotImplementedException();

        public decimal MaxHealth => throw new NotImplementedException();

        public void UseActiveAbility(IActiveAbility ability, ICell cell)
        {
            if (AmountEnergy < ability.Сost) return;

            decimal amount = ability.Execute(Power);

            if (amount < 0) cell.Model.ApplyDamage(amount);
            if (amount > 0) ApplyHealth(amount);

            OnTurnCompleted?.Invoke(this, EventArgs.Empty);
        }

        public bool TryMove(ICell? cell, IField field)
        {
            if (isMoved == true) throw new Exception("Юнит уже походил");
            if (cell?.Model != null) return false;
            
            if (field.GetNeighborsRadius(CellParent, DistanceOfMove).Contains(cell))
            {
                CellParent.Model = null;
                cell.Model = this;

                isMoved = true;
                return true;
            }

            return false;
        }

        public void ApplyDamage(decimal damageAmount)
        {
            decimal multuiplier = (1 - Armor);
            if (CurrentHealth - (multuiplier * damageAmount) <= 0)
            {
                Die();
                return;
            }

            CurrentHealth -= damageAmount * multuiplier;
        }

        public void ApplyHealth(decimal healthAmount)
        {
            if (MaxHealth > CurrentHealth + healthAmount)
            {
                CurrentHealth = MaxHealth;
                return;
            }

            CurrentHealth += healthAmount;
        }

        public void Die()
        {
            CellParent.Model = null;

            OnDead?.Invoke(this, this);
        }

        public abstract string GetSign();

        public void SkipTurn() {

            if (isMoved = false)
            {
                if (MaxEnergy >= AmountEnergy + MaxEnergy * (decimal)0.2) { AmountEnergy = MaxEnergy; }
                else { AmountEnergy += MaxEnergy * (decimal)0.2; }
            }

            OnTurnCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}
