﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public interface IAbility
    {
        string Description { get; set; }
        decimal Execute(decimal power);
    }
}
