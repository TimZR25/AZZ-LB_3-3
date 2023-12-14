using AZZ_LB_3_3.Main.CombatStageField;
using AZZ_LB_3_3.Main.PlayerField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStage
{
    public class CombatPresenter : ICombatStage
    {
        private PriorityQueue<IUnit, int> _unitsPriorityQueue;
        private List<IPlayer> _players;
        private IField _gameField;

        private List<IUnit> _unitsCanTakeAction;

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

        private IPlayer _currentPlayer;
        public IPlayer CurrentPlayer
        {
            get
            {
                return _currentPlayer;
            }
            set
            {
                foreach (IPlayer player in _players)
                {
                    if (player.ControlledUnits.Contains(CurrentUnit)) _currentPlayer = value;
                }
            }
        }

        public IUnit CurrentUnit { get; set; }


        public CombatPresenter(List<IPlayer> players, IField field, IRoundManager roundManager)
        {
            Players = players;
            GameField = field;
            round = roundManager;
            UnitsPriorityQueue = new();
            _unitsCanTakeAction = new List<IUnit>(AllUnits);
        }

        public void RebuildQueue()
        {
            _unitsPriorityQueue.Clear();

            foreach (IUnit unit in _unitsCanTakeAction)
            {
                _unitsPriorityQueue.Enqueue(unit, -unit.Initiative);
            }
        }

        public void NextTurn()
        {
            if (_unitsPriorityQueue.Count <= 0) RebuildQueue();

            CurrentUnit = _unitsPriorityQueue.Dequeue();
            _unitsCanTakeAction.Remove(CurrentUnit);
        }
    }
}
