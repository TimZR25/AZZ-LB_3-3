using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface ICell
    {
        public IModel? Model { get; }
        public List<Cell> Neighbors { get; set; }
        public void AddModelInCell(IModel model);
        public void ClearModelInCell();
    }
}
