﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Main
{
    public class RoundManager : IRoundManager
    {
        public int Round { get; set; }

        public RoundManager()
        {
            Round = 1;
        }

        public void NextRound()
        {
            //очередь
            Round++;
        }
    }
}