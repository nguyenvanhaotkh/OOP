using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP.demo
{
    class ProductDaoDemo
    {
        private ProductDemo productDemo;
        private ProductDAO productDAO;
        public ProductDaoDemo(ProductDemo productDemo, ProductDAO productDAO)
        {
            this.productDemo = productDemo;
            this.productDAO = productDAO;
        }

        public void Test()
        {
            productDemo.CreateProductTest();
            PrintData();

            Console.WriteLine("==Insert product==");
            Database.GetInstance().InsertTable(EntityType.product.ToString(), new Product(5, "product5", 5));
            PrintData();

            Console.WriteLine("==Update product==");
            Database.GetInstance().UpdateTable(EntityType.product.ToString(), new Product(5, "product5update", 55));
            PrintData();

            Console.WriteLine("==Delete product==");
            Database.GetInstance().Delete(EntityType.product.ToString(), 3);
            PrintData();

            Console.WriteLine("==Find product by id(2)==");
            Console.WriteLine(Database.GetInstance().FindById(EntityType.product.ToString(), 2).TxtData());

            Console.WriteLine("==Find product by name(product1)==");
            Console.WriteLine(Database.GetInstance().FindByName(EntityType.product.ToString(), "product1").TxtData());

            Console.WriteLine("Delete all product");
            Database.GetInstance().DeleteAll(EntityType.product.ToString());
            PrintData();

        }
        public void PrintData()
        {
            foreach (BaseRow row in Database.GetInstance().SelectTable(EntityType.product.ToString()))
            {
                Console.WriteLine(row.TxtData());
            }
        }
    }
}
