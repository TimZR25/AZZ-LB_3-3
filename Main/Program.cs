using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Program
    {
        public static void Main()
        {
            int sizeSide = 10;
            Field field = Field.getInstance(sizeSide);

            field.FieldOut();
            Console.WriteLine();

            IAbstractFactoryUnits abstractFactoryUnits = new OrcsFactoryUnits();

            field.AddModel(new Rock(), 0, 0);
            field.AddModel(abstractFactoryUnits.CreateArcher(), 1, 1);
            field.AddModel(abstractFactoryUnits.CreateWarrior(), 1, 2);

            Player player = new Player("Глеб", TypeFaction.ORCS, 100, "Красные");

            Unit unit = player.GetUnit(TypeRole.WARRIOR);
            player.AddUnit(unit); //реализовать разделение поля на стартовые зоны

            Console.WriteLine(player.Squad[0].Description);

            field.FieldOut();
            Console.WriteLine();

            Cell? cell = field.GetCell(1, 1);
            if(cell?.Model is Unit orche)
            {
                if (orche.TryMove(field.GetCell(2, 2)) == false)
                    Console.WriteLine("Упс клетка занята");
            }

            field.FieldOut();
            Console.WriteLine();

            field.ClearField();

            Cell? c = field.GetCell(4, 4);
            foreach (Cell cell1 in field.GetNeighborsRadius(c, 2))
            {
                cell1.AddModelInCell(new OrcRider());
            }
            field.FieldOut();
            Console.WriteLine();


            field.AddModel(abstractFactoryUnits.CreateWarrior(), 0, 1);
            Cell? ce = field.GetCell(0, 1);
            if (ce?.Model is Unit or) // подумать как тип
            {
                if (or.TryMove(field.GetCell(2, 0)) == false)
                    Console.WriteLine("Упс клетка занята");
            }

            field.FieldOut();
        }
    }
}
