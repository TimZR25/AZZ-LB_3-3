using AZZ_LB_3_3.Main.CombatStage;
using AZZ_LB_3_3.Main.PlayerField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStageField
{
    public class CombatManager : ICombatManager
    {
        private IField _gameField;
        private List<IPlayer> _players;
        private IRoundManager _roundManager;
        public IUnit CurrentUnit { get; set; }
        public List<IUnit> UnitsCanTakeAction { get; set; }
        public PriorityQueue<IUnit, int> UnitsPriorityQueue { get; set; }
        public IPlayer CurrentPlayer { get; set; }
        public IField GameField
        {
            get { return _gameField; }
            set { _gameField = value; }
        }
        public List<IPlayer> Players
        {
            get { return _players; }
            set { _players = value; }
        }
        public IRoundManager RoundManager 
        {
            get { return _roundManager; }
            set { _roundManager = value; } 
        }
        public CombatManager(IField gameField, List<IPlayer> players, IRoundManager roundManager)
        {
            GameField = gameField;
            Players = players;
            RoundManager = roundManager;
        }
        public void ChangeCurrentPlayer()
        {
            foreach (IPlayer player in _players)
            {
                if (player.ControlledUnits.Contains(CurrentUnit)) CurrentPlayer = player;
            }
        }
        public void ChangeUnitsCanTakeAction()
        {
            foreach (IPlayer player in Players)
            {
                foreach (IUnit unit in player.ControlledUnits)
                {
                    UnitsCanTakeAction.Add(unit);
                }
            }
        }
        public void RebuildQueue()
        {
            UnitsPriorityQueue.Clear();

            foreach (IUnit unit in UnitsCanTakeAction)
            {
                UnitsPriorityQueue.Enqueue(unit, -unit.Stats.Initiative);
            }
        }

        public void NextTurn()
        {
            if (UnitsPriorityQueue.Count <= 0)
            {
                RoundManager.NextRound();

                RebuildQueue();
            }

            CurrentUnit = UnitsPriorityQueue.Dequeue();
            UnitsCanTakeAction.Remove(CurrentUnit);
        }

    }
}
