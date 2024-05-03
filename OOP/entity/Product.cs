using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Product : BaseRow
    {
        private int categoryId;
        public Product() { }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }

        public int GetCategoryId()
        {
            return categoryId;
        }

        public void SetCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public override string TxtData()
        {
            return "Id:" + this.id + " - Name:" + this.name + " - Category Id:" + this.categoryId;
        }
    }
}
