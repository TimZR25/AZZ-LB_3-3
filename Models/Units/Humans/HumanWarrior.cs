﻿namespace AZZ_LB_3_3
{
    public class HumanWarrior : Unit
    {
        public HumanWarrior()
        {
            Description = "Человек-воин умело командует войском";
            _distanceOfMove = 2;
        }

        public override string GetSign()
        {
            return "OW";
        }
    }
}
