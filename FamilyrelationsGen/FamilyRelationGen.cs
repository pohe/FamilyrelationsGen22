using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyrelationsGen
{
    public class FamilyRelationGen<T>
    {
        private T _self;
        private T _father;
        private T _mother;
        private List<T> _children;

        public FamilyRelationGen(T self, T father, T mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<T>();
        }

        public T Self { get { return _self; } }

        public T Father { get { return _father; } }

        public T Mother { get { return _mother; } }

        public List<T> Children { get { return _children; } }

        public void AddChild(T child)
        {
            _children.Add(child);
        }

        //Override the Tostring methods to printout the family relations
        public override string ToString()
        {
            string children = "";
            foreach (T tChild in Children)
            {
                children += tChild.ToString() + " ";
            }
            return $"Name of dog {Self.ToString()} mother {Mother.ToString()} father {Father.ToString()} chrildren {children} ";
        }
    }
}
