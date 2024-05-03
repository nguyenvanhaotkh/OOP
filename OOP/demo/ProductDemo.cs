using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.demo
{
    class ProductDemo : Product
    {
        public Product CreateProductTest()
        {
            return new Product();
        }
        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.TxtData());
        }
    }
}
