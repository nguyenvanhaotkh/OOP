using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.entity
{
    class Product
    {
        public int id;
        public string name;
        public int categoryId;
        public Product() { }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetCategoryId()
        {
            return categoryId;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetCategoryId(int categoryId)
        {
            this.categoryId = categoryId;
        }

        public string TxtData()
        {
            return "Id:" + this.id + " - Name:" + this.name + " - Category Id:" + this.categoryId;
        }
    }
}
