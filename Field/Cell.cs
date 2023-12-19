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
        private IUnit? _unit;
        public List<ICell> _neighbors;
        public IObstacle? Obstacle { get; set; }
        public IUnit? Unit
        {
            get { return _unit; }
            set
            {
                _unit = value;
                if(_unit != null)
                    _unit.CellParent = this;
            }
        }
        public List<ICell> Neighbors { get; private set; }       

        public Cell(int x, int y)
        {
            Neighbors = new List<ICell>();
        }
    }
}
