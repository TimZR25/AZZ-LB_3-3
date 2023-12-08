using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class FieldPrint : IFieldPrint
    {
        public void FieldOut(ICell[,] field)
        {
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    Console.Write(field[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
