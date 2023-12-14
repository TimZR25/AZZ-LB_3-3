using AZZ_LB_3_3.Main.CombatStageField;
using AZZ_LB_3_3.Main.PlayerField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStage
{
    public class CombatStage : ICombatStage
    {
        private PriorityQueue<IUnit, int> _unitsPriorityQueue;
        private List<IPlayer> _players;
        private IField _gameField;

        private List<IUnit> _invokedUnits;


        public IRoundManager round;

        public List<IUnit> AllUnits
        {
            get
            {
                List<IUnit> units = new List<IUnit>();

                foreach (IPlayer player in _players)
                {
                    units.Concat(player.ControlledUnits);
                }
                
                return units;
            }
        }

        public PriorityQueue<IUnit, int> UnitsPriorityQueue
        {
            get { return _unitsPriorityQueue; }
            private set { _unitsPriorityQueue = value; }
        }

        public List<IPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }

        public IField GameField
        {
            get { return _gameField; }
            private set { _gameField = value; }
        }

        //проверки для всех свойств
        public CombatStage(List<IPlayer> players, IField field, IRoundManager roundManager)
        {
            Players = players;
            GameField = field;
            round = roundManager;
            UnitsPriorityQueue = new();
        }

        public void AddUnitList(IUnit unit)
        {
            AllUnits.Add(unit);
        }

        public void RebuildQueue()
        {
            _unitsPriorityQueue.Clear();

            foreach (IPlayer player in _players)
            {
                foreach (IUnit unit in player.ControlledUnits)
                {
                    _unitsPriorityQueue.Enqueue(unit, -unit.UnitStats.Initiative);
                }
            }
        }
    }
}
