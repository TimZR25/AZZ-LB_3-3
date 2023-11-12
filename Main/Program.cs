using AZZ_LB_3_3.Factions;
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

            IAbstractFactoryUnits abstractFactoryUnits = new OrksFactoryUnits();

            field.AddModel(new Rock(), 0, 0);
            field.AddModel(new Orc(), 1, 1);
            field.AddModel(abstractFactoryUnits.CreateWarrior(), 1, 2);

            field.FieldOut();
        }
    }
}
