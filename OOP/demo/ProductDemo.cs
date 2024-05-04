using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.dao;
namespace OOP.demo
{
    class ProductDemo
    {
        public void CreateProductTest()
        {
            Database.GetInstance().InsertTable(EntityType.product.ToString(), new Product(1, "product1", 1));
            Database.GetInstance().InsertTable(EntityType.product.ToString(), new Product(2, "product2", 2));
            Database.GetInstance().InsertTable(EntityType.product.ToString(), new Product(3, "product3", 3));
            Database.GetInstance().InsertTable(EntityType.product.ToString(), new Product(4, "product4", 4));
        }
        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.TxtData());
        }
    }
}
