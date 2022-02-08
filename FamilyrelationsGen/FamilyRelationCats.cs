using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyrelationsGen
{
    class FamilyRelationCats
    {
        private Cat _self;
        private Cat _father;
        private Cat _mother;
        private List<Cat> _children;

        public FamilyRelationCats(Cat self, Cat father, Cat mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<Cat>();
        }

    }
}
