using AZZ_LB_3_3.Factions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
     public class Player
    {
        private string _name;
       
        private List<Unit> _squadUnits;
       
        private int _totalScore;
       
        private string _groupPlayer;
       
        private IAbstractFactoryUnits _unitFactory;
       
        public string Name
        {
            get 
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }

        public List<Unit> Squad
        {
            get
            {
                return _squadUnits;
            }
            private set
            {
                _squadUnits = value;
            }
        }
       
        public int TotalScore
        {
            get
            {
                return _totalScore;
            }
            private set
            {
                _totalScore = value;
            }
        }

        public string GroupPlayer
        {
            get
            {
                return _groupPlayer;
            }
            private set
            {
                _groupPlayer = value;
            }
        }

        public Player(string name, Faction factionPlayer, int totalScore, string groupPlayer)
        {
            Name = name;
            TotalScore = totalScore;
            GroupPlayer = groupPlayer;
            Squad = new();
            switch (factionPlayer) {
                case Humans:
                    _unitFactory = new HumansFactoryUnits();
                    break;
                 //доделать остальные фракции
            }
        }

        public void AddUnit(Unit unit)
        {
            Squad.Add(unit);
        }
    }
}
