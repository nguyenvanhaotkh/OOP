using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.demo
{
    class CategoryDemo
    {
        public Category CreateProductTest(int id, string name)
        {
            return new Category(id, name);
        }
        public void PrintProduct(BaseRow category)
        {
            Console.WriteLine(category.TxtData());
        }
    }
}
