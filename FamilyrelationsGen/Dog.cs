using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyrelationsGen
{
    public class Dog : IHasName
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Dog)
            //if (obj.GetType() is Dog)
                return ((Dog) obj).Name == this.Name;
            else
            {
                return false;
            }
           
        }

        public override string ToString()
        {
            return $"{Name} ";
        }
    }
}
