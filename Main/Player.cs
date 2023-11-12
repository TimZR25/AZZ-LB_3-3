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
        //private Faction _factionPlayer;
        private int _totalScore;
        private string _groupPlayer;

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
        //public Faction FactionPlayer
        //{
        //    get
        //    {
        //        return _factionPlayer;
        //    }
        //    private set
        //    {
        //        _factionPlayer = value;
        //    }
        //}
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

        //public Player(string name, Faction factionPlayer, int totalScore, string groupPlayer)
        //{
        //    Name = name;
        //    FactionPlayer = factionPlayer;
        //    TotalScore = totalScore;
        //    GroupPlayer = groupPlayer;
        //    Squad = new();
        //}

        public void AddUnit(Unit unit)
        {
            Squad.Add(unit);
        }
    }
}
