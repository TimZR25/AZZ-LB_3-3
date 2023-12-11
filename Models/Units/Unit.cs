using AZZ_LB_3_3.Models.Units;

namespace AZZ_LB_3_3
{
    public abstract class Unit : IUnit
    {
        public string? Name { get; }

        protected int _maxHealth;

        protected int _health;

        protected decimal Power { get; set; }

        protected int _armor;

        public string? Description { get; protected set; }

        protected int _distanceOfMove;

        protected int _initiative;

        public int Score { get; }



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
