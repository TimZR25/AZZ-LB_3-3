﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Abilities.ActriveAbilities
{
    public class Archery
    {
        public string Description { get; set; }
        public int Сost { get; set; }

        public Archery(int сost) // подумать
        {
            Description = "Обычный выстрел из лука";
            Сost = сost;
        }

        public decimal Execute(decimal power)
        {
            return power * 2;
        }
    }
}