using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Question01
{
    internal interface IRectangle
    {
        double Length { get; set; }
        double Width { get; set; }
        void CalculateArea();
    }
}
