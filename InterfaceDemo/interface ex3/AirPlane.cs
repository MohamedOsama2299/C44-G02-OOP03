using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.interface_ex3
{
    internal class AirPlane : IMoveable, IFlyAble
    {
        int IMoveable.speed { get; set; }
        int IFlyAble.speed { get; set; }

        // IMoveable Implementation
        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlane moving backward on ground");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlane moving forward on ground");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlane turning left on ground");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlane turning right on ground");
        }
        void IFlyAble.Backward()
        {
            Console.WriteLine("AirPlane flying backward");
        }

        void IFlyAble.Forward()
        {
            Console.WriteLine("AirPlane flying forward");
        }

        void IFlyAble.Left()
        {
            Console.WriteLine("AirPlane turning left in the air");
        }

        void IFlyAble.Right()
        {
            Console.WriteLine("AirPlane turning right in the air");
        }
    }
}