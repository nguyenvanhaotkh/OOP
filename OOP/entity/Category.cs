using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Category : BaseRow
    {
        public Category() { }
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
