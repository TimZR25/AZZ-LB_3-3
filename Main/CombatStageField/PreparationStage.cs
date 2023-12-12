﻿using AZZ_LB_3_3.Main.PlayerField;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main.CombatStage
{
    public class PreparationStage
    {
        private IField _field;
        private List<IDataPlayer> _listDataPlayers;
        private List<IUnit> _allUnits;

        PreparationStage(Field field, List<IDataPlayer> listIDataPlayer)
        {
            _field = field;
            _listDataPlayers = listIDataPlayer;
        }

        private void AddUnit(IDataPlayer player, IUnit unit)
        {
            if (player.Score > unit.Score)
            {

                player.Score = player.Score - unit.Score;
                _allUnits.Add(unit);

            }
            else
            {
                //вывести сообщение об невозможности добавления
            }
        }

        //public void CreateUnits()
        //{
        //    foreach (IPlayer player in _players)
        //    {
        //        AddUnit();

        //    }
        //}

        //public bool RemoveUnit(Player player, Unit unit)
        //{

        //    foreach (Unit unitInSquadPlayer in player.Squad)
        //    {
        //        if (unitInSquadPlayer.Name.Equals(unit.Name))
        //        {
        //            player.TotalScore = player.TotalScore + unit.Score;
        //            _allUnits.Remove(unitInSquadPlayer);
        //            return true;
        //        }//проверить на правильность foreach
        //        return false;
        //    }

        //    //for (int i = 0; i < player.Squad.Count; i++)
        //    //{
        //    // unitInSquadPlayer
        //    // if (unitInSquadPlayer.Name.Equals(unit.Name))
        //    // {
        //    // player.TotalScore = player.TotalScore + unit.Score;
        //    // _allUnits.Remove(unit);

        //    // }
        //    //}
        //}
    }
}