using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Tom_And_Jerry
{
    internal class Jerry  : ICartoonCharacter
    {
        public string Name { get; set; } = "Jerry";

        public void ShowTalent()
        {
            Console.WriteLine($"Hi, I'm {Name}");
            Console.WriteLine("I just ate 3 blocks of cheese, locked Tom outside, and started a dance party.");
        }
    }  
}
