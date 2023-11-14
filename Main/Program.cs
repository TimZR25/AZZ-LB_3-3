using AZZ_LB_3_3.Models.Units.Roles;
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
            int sizeSide = 3;
            Field field = Field.getInstance(sizeSide);

            field.FieldOut();
            Console.WriteLine();

            IAbstractFactoryUnits abstractFactoryUnits = new OrcsFactoryUnits();

            field.AddModel(new Rock(), 0, 0);
            field.AddModel(new OrcArcher(), 1, 1);
            field.AddModel(abstractFactoryUnits.CreateWarrior(), 1, 2);

            Player player = new Player("Глеб", TypeFaction.ORCS, 100, "Красные");

            Unit unit = player.GetUnit(TypeRole.WARRIOR);
            player.AddUnit(unit); //реализовать разделение поля на стартовые зоны

            Console.WriteLine(player.Squad[0].Description);

            field.FieldOut();
            Console.WriteLine();

            Cell? cell = field.GetCell(1, 1);
            if(cell?.Model is Orc orche)
            {
                if (orche.TryMove(field.GetCell(2, 2)) == false)
                    Console.WriteLine("Упс клетка занята");
            }

            field.FieldOut();
        }
    }
}
