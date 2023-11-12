using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class GameMaster
    {
        private int _round;
        private List<Unit> _allUnits;
        private PriorityQueue<Unit,int> _unitsPriorityQueue;
        private List<Player> _players;
        private Field _gameField;

        public int Round
        {
            get
            {
                return _round;
            }
            private set
            {
                _round = value;
            }
        }

        public List<Unit> AllUnits
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

        public PriorityQueue<Unit, int> UnitsPriorityQueue
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

        public List<Player> Players
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

        public Field GameField
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


        public GameMaster(List<Player> players, Field field)
        {
            Players = players;
            GameField = field;
            Round = 0;
            AllUnits = new();
            UnitsPriorityQueue = new();
        }

        public void ChangeRound()
        {
            //определяется новая очередь
            Round++;
        }

        //метод проверка на количество живых юнитов

        public void AddUnitList(Unit unit)
        {
            AllUnits.Add(unit);
        }
    }
}
