using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public interface IUnitStats
    {
        public string Name { get; }

        public decimal MaxHealth { get; set; }

        public decimal CurrentHealth { get; set; }

        public decimal Power { get; set; }

        public int Armor { get; set; }

        public string Description { get;  set; }

        public int DistanceOfMove { get; set; }

        public int Initiative { get; set; }

        public int Score { get; }

        public int AmountEnergy { get; set; }
        public List<IActiveAbility> ActiveAbilities { get; set; }
        public List<IPassiveAbility> PassiveAbilities { get; set; }
    }
}