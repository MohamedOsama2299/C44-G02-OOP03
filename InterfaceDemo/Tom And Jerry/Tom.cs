using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Tom_And_Jerry
{
    internal class Tom : ICartoonCharacter
    {
        public string Name { get; set; } = "Tom";

        public void ShowTalent()
        {
            Console.WriteLine($"Hi, I'm {Name}");
            Console.WriteLine("My talent? I chase Jerry all day  and my own traps. It's a skill!");
        }
    }
}