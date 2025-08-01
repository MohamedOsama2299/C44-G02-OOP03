﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Question01
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }
        public void CalculateArea()
        {
            Area = Length * Width;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Area of Rectangle: {Area}");
        }
    }
}
