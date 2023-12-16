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

        private IModel? _model;

        public IModel? Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _model.CellParent = this;
            }
        }
        public List<ICell> Neighbors { get; set; }       

        public Cell(int x, int y)
        {
            Neighbors = new List<ICell>();
        }
    }
}
