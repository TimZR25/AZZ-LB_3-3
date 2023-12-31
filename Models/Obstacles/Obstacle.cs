﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3.Models.Obstacles
{
    public class Obstacle : IObstacle
    {
        private string _description;
        public string Description 
        {
            get { return _description; }
            set { _description = value; }
        }
        public Obstacle(string description)
        {
            Description = description;
        }
    }
}
