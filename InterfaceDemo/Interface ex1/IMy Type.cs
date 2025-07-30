using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Interface_ex1
{
    internal interface IMyType
    {
        //What can write inside interface?
        //1.signature of properties
        //2.signature of methods [Name ,Prameter,Return Type,]
        //3. default implemented  methods [Fully Implemented Method]


        //2.signature of methods [Name ,Prameter,Return Type,]
        void Myfun();

        //1.signature of properties
        double salary { get; set; }

        //3. default implemented  methods [Fully Implemented Method]

        void print()
        {
            Console.WriteLine("default implemented  methods ");
        }
    }
}
