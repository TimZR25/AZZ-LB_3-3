using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AZZ_LB_3_3.Main.CombatStage;
using AZZ_LB_3_3.Main.PlayerField;

namespace AZZ_LB_3_3
{
    public class Program
    {
        public static void Main()
        {
            //int sizeSide = 10;
            //Field field = new Field(sizeSide);

            //field.FieldOut();
            //Console.WriteLine();

            //IAbstractFactoryUnits abstractFactoryUnits = new OrcsFactoryUnits();

            //field.AddModel(abstractFactoryUnits.CreateWarrior(), 1, 2);
            //field.AddModel(abstractFactoryUnits.CreateArcher(), 1, 1);
            //field.AddModel(abstractFactoryUnits.CreateMage(), 2, 2);
            //field.AddModel(abstractFactoryUnits.CreateRider(), 4, 4);

            //ICell? rockCell = field.GetCell(8, 8);
            //rockCell.Model = new Rock();
            //foreach (ICell c in field.GetNeighborsRadius(rockCell, 1)) c.Model = new Rock();


            //rockCell = field.GetCell(8, 1);
            //rockCell.Model = new Rock();
            //foreach (ICell c in field.GetNeighborsRadius(rockCell, 2)) c.Model = new Rock();

            //field.FieldOut();
            //Console.WriteLine();



            //ICell? cell = field.GetCell(4, 4);
            //if (cell?.Model is Unit unit) // подумать убрать проверку на тип
            //{
            //    if (unit.TryMove(field.GetCell(4, 7), field) == false)
            //        Console.WriteLine("Упс клетка занята");
            //}

            //field.FieldOut();
            //field.ClearField();


            //Console.WriteLine("------------------Тест GM--------------------\n");

            //List<Player> players = new List<Player>() { new Player("p1", TypeFaction.ORCS), new Player("p2", TypeFaction.ORCS) };
            ////как-то получили пользователей

            ////какая-то расстановка юнитов(0 ход)
        }
    }
}