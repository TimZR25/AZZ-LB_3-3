using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Cell
    {
        public int X { get; }

        public int Y { get; }

        public IModel? Model { get; private set; }

        string sign = "0";
        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return sign + " ";
        }
        public void AddModelInCell(IModel model)
        {
            Model = model;
            sign = model.GetSign();
        }
    }
}
