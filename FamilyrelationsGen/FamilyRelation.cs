using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyrelationsGen
{
    public class FamilyRelation
    {
        private Dog _self;
        private Dog _father;
        private Dog _mother;
        private List<Dog> _children;

        public FamilyRelation(Dog self, Dog father, Dog mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<Dog>();
        }

        public Dog Self { get { return _self; } }

        public Dog Father { get { return _father; } }

        public Dog Mother { get { return _mother; } }

        public List<Dog> Children { get { return _children; } }

        public void AddChild(Dog child)
        {
            _children.Add(child);
        }

        //Override the Tostring methods to printout the family relations
        public override string ToString()
        {
            string children = "";
            foreach (Dog dog in Children)
            {
                children += dog.Name + " ";
            }
            return $"Name of dog {Self.Name} mother {Mother.Name} father {Father.Name} chrildren {children} ";
        }
    }
}
