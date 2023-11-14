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

        public Player(string name, TypeFaction factionPlayer, int totalScore, string groupPlayer)
        {
            Name = name;
            TotalScore = totalScore;
            GroupPlayer = groupPlayer;
            Squad = new();
            _unitFactory = new FactoriesUnitsFactory().CreateFactory(factionPlayer);
        }

        public Unit GetUnit(TypeRole role)
        {
            switch (role)
            {
                case TypeRole.WARRIOR:
                    return _unitFactory.CreateWarrior();
                case TypeRole.ARCHER:
                    return _unitFactory.CreateArcher();
                case TypeRole.MAGE:
                    return _unitFactory.CreateMage();
                case TypeRole.RIDER:
                    return _unitFactory.CreateRider();
            }
            throw new ArgumentOutOfRangeException("Нельзя получить юнита с такой ролью");
        }

        public void AddUnit(Unit unit)
        {
            if (unit == null) throw new NullReferenceException("Игрок получил пустую ссылку на юнита");

            Squad.Add(unit);
        }
    }
}
