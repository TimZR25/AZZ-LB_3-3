using AZZ_LB_3_3.Models.Units.Roles;
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
            switch (factionPlayer) {
                case TypeFaction.HUMANS:
                    _unitFactory = new HumansFactoryUnits();
                    break;
                case TypeFaction.ORCS:
                    _unitFactory = new OrcsFactoryUnits();
                    break;
                case TypeFaction.UNDEADS:
                    _unitFactory = new UndeadsFactoryUnits();
                    break;
            }
        }

        public Unit GetUnit(TypeRole role)
        {
            //if (role == null) throw new ArgumentNullException("Пустая ссылка не может быть ролью");
            //if (role is IWarrior) return _unitFactory.CreateWarrior();
            //if (role is IArcher) return _unitFactory.CreateArcher();
            //if (role is IMage) return _unitFactory.CreateMage();
            //if (role is IRider) return _unitFactory.CreateRider();

            //throw new ArgumentNullException("Такой роли не существует");

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
                default:
                    break;
            }

            return null;
        }

        public void AddUnit(Unit unit)
        {
            Squad.Add(unit);
        }
    }
}
