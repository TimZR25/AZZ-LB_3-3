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

        private const string _startSign = "..";

        private string _sign;

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
            _sign = _startSign;
        }

        public override string ToString()
        {
            return _sign + " ";
        }

        public void AddModelInCell(IModel model)
        {
            Model = model;
            Model.CellParent = this;
            _sign = model.GetSign();
        }

        public void ClearModelInCell()
        {
            Model = null;
            _sign = _startSign;
        }
    }
}
