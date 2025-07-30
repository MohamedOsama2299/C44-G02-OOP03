using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Tom_And_Jerry
{
    internal interface ICartoonCharacter
    {
        string Name { get; set; }
        void ShowTalent();
    }
}
