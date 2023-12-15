using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Cell : ICell
    {
        private const string _startSign = "..";

        private string _sign;

        private IModel? _model;

        public IModel? Model
        {
            get { return _model; }
            set
            {
                _model = value;

                if (value == null)
                {
                    _sign = _startSign;
                    return;
                }

                _model.CellParent = this;
                _sign = value.GetSign();
            }
        }

        public List<ICell> Neighbors { get; set; }       

        public Cell(int x, int y)
        {
            Neighbors = new List<ICell>();
            _sign = _startSign;
        }

        public override string ToString()
        {
            return _sign + " ";
        }
    }
}
