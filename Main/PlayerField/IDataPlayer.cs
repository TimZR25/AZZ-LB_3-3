using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.PlayerField
{
    public interface IDataPlayer
    {
        public string Name { get; set; }
        public TypeFaction Faction { get; set; }// сделать проверку для всего
        public int Score { get; set; }
    }
}