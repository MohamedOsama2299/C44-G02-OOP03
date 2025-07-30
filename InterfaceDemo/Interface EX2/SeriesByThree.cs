using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interface_EX2
{
    internal class SeriesByThree : Iseries
    {
        public int Current { get; set; } //0
        public void Next()
        {
            Current += 3;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
}