using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStage
{
    public interface IRoundManager
    {
        public int Round { get; set; }

        public void NextRound();
    }
}