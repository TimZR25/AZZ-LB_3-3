using AZZ_LB_3_3.Main.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStage
{
    public class CombatStage
    {
        private List<IUnit> _allUnits;
        private PriorityQueue<IUnit, int> _unitsPriorityQueue;
        private List<IPlayer> _players;
        private IField _gameField;


        public IRoundManager round;

        public List<IUnit> AllUnits
        {
            get
            {
                return _allUnits;
            }
            private set
            {
                _allUnits = value;
            }
        }

        public PriorityQueue<IUnit, int> UnitsPriorityQueue
        {
            get
            {
                return _unitsPriorityQueue;
            }
            private set
            {
                _unitsPriorityQueue = value;
            }
        }

        public List<IPlayer> Players
        {
            get
            {
                return _players;
            }
            private set
            {
                _players = value;
            }
        }

        public IField GameField
        {
            get
            {
                return _gameField;
            }
            private set
            {
                _gameField = value;
            }
        }

        //проверки для всех свойств
        public CombatStage(List<IPlayer> players, IField field)
        {
            Players = players;
            GameField = field;
            round = new RoundManager();
            AllUnits = new();
            UnitsPriorityQueue = new();
        }

        //метод проверка на количество живых юнитов

        public void AddUnitList(IUnit unit)
        {
            AllUnits.Add(unit);
        }
    }
}
