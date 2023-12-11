namespace AZZ_LB_3_3
{
    public abstract class Unit : IModel
    {
        protected string? _name;

        protected decimal _maxHealth;

        protected decimal _health;

        protected int _armor;

        protected decimal _amountEnergy;

        public string? Description { get; protected set; }

        protected int _distanceOfMove;

        protected int _distanceAttack;

        protected decimal _initiative;

        protected int _score;

        protected string? _playerName;

        protected List<IAbility>? _passiveAbilities;
        protected List<IAbility>? _activeAbilities;

        public Cell? CellParent { get; set; }

        public abstract void UseAbility(IAbility ability);

        public bool TryMove(Cell? cell)
        {
            if (cell?.Model != null) return false;
            
            if (Field.getInstance(5).GetNeighborsRadius(CellParent, _distanceOfMove).Contains(cell))
            {
                CellParent?.ClearModelInCell();
                cell?.AddModelInCell(this);

                return true;
            }

            return false;
        }

        public abstract void ApplyDamage(float amount);

        private void Die() { } // сделать

        public abstract string GetSign();
    }
}
