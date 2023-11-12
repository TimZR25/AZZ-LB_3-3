using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Rock : IObstacle
    {
        public Cell? CellParent { get; set; }

        public string GetSign()
        {
            return "Ro";
        }
    }
}
