using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Question01
{
        internal class Circle : ICircle
        {
      
            public double Radius { get; set ; }
        public double Area { get; set; }
        public void CalculateArea()
            {
              Area=Radius* Radius*3.14;
            }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area of Circle {Area}:");
        }
    }
    }
