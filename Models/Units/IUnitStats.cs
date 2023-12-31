﻿using AZZ_LB_3_3.Abilities;

namespace AZZ_LB_3_3
{
    public interface IUnitStats
    {
        public string Name { get; set; }

        public decimal MaxHealth {  get; set; }

        public decimal CurrentHealth { get; set; }

        public decimal MaxEnergy { get; set; }

        public decimal CurrentEnergy { get; set; }

        public decimal Power { get; set; }

        public int MaxArmor { get; set; }

        public int Armor { get; set; }

        public int DistanceOfMove { get; set; }

        public int Initiative { get; set; }

        public string Description { get;  set; }

        public List<IPassiveAbility>? PassiveAbilities { get; set; }

        public List<IActiveAbility>? ActiveAbilities { get; set; }
    }
}