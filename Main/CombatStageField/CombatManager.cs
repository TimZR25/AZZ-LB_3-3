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
            foreach (IUnit unit in GetAllUnits())
            {
                UnitsCanTakeAction.Add(unit);
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

        private void SubscribeUnitEvent() {
            foreach (IUnit unit in GetAllUnits()) {
                unit.OnTurnCompleted += NextTurn;
            }
        }


        public void NextTurn(object sender, EventArgs args) // запускает сразу(0 раунда)
        {
            if (UnitsPriorityQueue.Count == 0)
            {
                if (RoundManager.Round != 0) { ApplyAllPassiveAbilities(); }

                RoundManager.NextRound();

                ChangeUnitsCanTakeAction();

                RebuildQueue();
            }


            UnitsCanTakeAction.Remove(CurrentUnit);
            CurrentUnit = UnitsPriorityQueue.Dequeue();
            ChangeCurrentPlayer();
        }

        public IPlayer MessageLosePlayer() {//проверка
            return CurrentPlayer;
        }//вывод информации об проигрыше игрока

        public void ApplyAllPassiveAbilities() {
            foreach (IUnit unit in GetAllUnits()) {
                unit.ApplyPassiveAbilities();
            }
        }

        public List<IUnit> GetAllUnits()
        {
            List<IUnit> result = new List<IUnit>();

            foreach (IPlayer player in Players)
            {
                foreach (IUnit unit in player.ControlledUnits)
                {
                    result.Add(unit);
                }
            }

            return result;
        }

    }
}
