using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IField
    {
        void AddModel(IModel model, int x, int y);
        public void ClearField();
    }
}
