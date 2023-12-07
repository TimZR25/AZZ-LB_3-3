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
        public IModel? Model { get; private set; }

        public List<Cell> Neighbors { get; set; }

        private const string _startSign = "..";

        private string _sign;

        public Cell(int x, int y)
        {
            Neighbors = new List<Cell>();
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
