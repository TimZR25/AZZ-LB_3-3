using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AZZ_LB_3_3.Main.PlayerField
{
    public interface IPlayer
    {
        public string Name { get; set; }

        public List<IUnit> ControlledUnits { get; set; }

    }
}
