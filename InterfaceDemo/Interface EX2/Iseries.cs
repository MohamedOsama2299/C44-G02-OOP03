using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interface_EX2
{

    internal interface Iseries
    {
        public int Current { get; set; } //signature of property
        void Next(); 
        void Reset(); 
    }
}
