using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.PlayerField
{
    public class Player : IPlayer
    {
        private string _name;

        private List<IUnit> _controlledUnits;

        private IAbstractFactoryUnits _unitFactory;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public List<IUnit> ControlledUnits
        {
            get
            {
                return _controlledUnits;
            }
            set
            {
                _controlledUnits = value;
            }
        }

        public Player(string name, TypeFaction factionPlayer)
        {
            Name = name;
            ControlledUnits = new();
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

        public void AddUnit(IUnit unit)
        {
            if (unit == null) throw new NullReferenceException("Игрок получил пустую ссылку на юнита");

            unit.OnDead += RemoveUnit;

            ControlledUnits.Add(unit);
        }

        public void RemoveUnit(object sender, IUnit unit)
        {
            unit.OnDead -= RemoveUnit;

            ControlledUnits.Remove(unit);
        }
    }
}
