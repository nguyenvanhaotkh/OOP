using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.demo
{
    class ProductDemo
    {
        public Product CreateProductTest(int id, string name, int categoryId)
        {
            return new Product(id,name,categoryId);
        }
        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.TxtData());
        }
    }
}
