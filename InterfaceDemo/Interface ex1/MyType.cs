using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interface_ex1
{
    internal class MyType:  Program ,IMyType
    {
        public double salary { get ; set ; }
        public void Myfun()
        {
            Console.WriteLine("Hello world");
        }
    }
}
