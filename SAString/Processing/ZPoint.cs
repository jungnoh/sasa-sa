﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAString.Processing
{
    public class ZPoint
    {
        public ZPoint (double X, double Y, double Z)
        {
            x = X; y = Y; z = Z;
        }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }
}