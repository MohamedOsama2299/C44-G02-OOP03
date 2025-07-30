using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Tom_And_Jerry
{
    internal class Spike : ICartoonCharacter
    {
        public string Name { get; set; } = "Spike";

        public void ShowTalent()
        {
            Console.WriteLine($"Hi, I'm {Name}");
            Console.WriteLine("Talent? Scaring Tom with just one growl  Also I bake cookies on weekends. Don’t tell anyone.");
        }
    }
}