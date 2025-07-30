using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.interface_ex3
{
    internal class Car : IMoveable
    {
        public int speed { get; set; }

        public void Backward()
        {
            Console.WriteLine("Car IMoveable   Backward");
        }

        public void Forward()
        {
            Console.WriteLine("Car IMoveable Foerward");
        }

        public void Left()
        {
            Console.WriteLine("Car IMoveable   Backward");
        }

        public void Right()
        {
            Console.WriteLine("Car IMoveable   Right");
        }
    }
}
