﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Question01
{
    internal interface ICircle : IShape
    {
         double Radius { get; set; }
            void CalculateArea();

    }
}
