using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    class Cell
    {
        public int x { get; }

        public int y { get; }

        private bool isEmpty = true;

        IModel model;

        string sign = "0";
        public Cell(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return sign + " ";
        }
        public void AddModelInCell(IModel model)
        {
            this.model = model;
            sign = model.GetSign();
        }
        public bool GetIsEmpty()
        {
            return isEmpty;
        }
    }
}
