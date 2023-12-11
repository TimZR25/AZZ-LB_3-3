using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main
{
    public interface IFirstStageView
    {
        //int SizeMatix { get; set; }
        string Name { get; set; }
        public TypeFaction Faction { get; set; }// сделать проверку для всего
        public int Score { get; set; }
    }
}