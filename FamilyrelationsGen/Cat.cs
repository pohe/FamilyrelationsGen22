using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyrelationsGen
{
    public class Cat: IHasName
    {
        public string Name { get; set; }

        public string  Color { get; set; }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public override string ToString()
        {
            return $"Kattens navn er {Name} og farve {Color}";
        }
    }
}
