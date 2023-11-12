﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZZ_LB_3_3
{
    public class Program
    {
        public static void Main()
        {
            int sizeSide = 3;
            Field field = Field.getInstance(sizeSide);

            field.FieldOut();
            Console.WriteLine();

            field.AddModel(new Rock(), 0, 0);
            field.AddModel(new Orc(), 1, 1);

            field.FieldOut();
        }
    }
}