using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IUnit : IModel
    {
        public string PlayerName { get; set; }

        public int Initiative { get; set; }

        public int Score { get; }

        public bool TryMove(ICell cell, IField field);
    }
}
