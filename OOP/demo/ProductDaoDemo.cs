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
        public ProductDaoDemo(ProductDemo productDemo,ProductDAO productDAO)
        {
            this.productDemo = productDemo;
            this.productDAO = productDAO;
        }

        public void Test()
        {
            productDemo.CreateProductTest();
            PrintData();

            Console.WriteLine("\n==Insert product==");
            productDAO.Insert(EntityType.product, new Product(5, "product5", 5));
            PrintData();

            Console.WriteLine("\n==Update product (id=5)==");
            Console.WriteLine("Old data: " + Database.GetInstance().FindById(EntityType.product.ToString(), 5).TxtData());
            productDAO.Update(EntityType.product, new Product(5, "product5update", 55));
            Console.WriteLine("New data: " + Database.GetInstance().FindById(EntityType.product.ToString(), 5).TxtData());

            Console.WriteLine("\n==Delete product (id=3)==");
            productDAO.Delete(EntityType.product, 3);
            PrintData();

            Console.WriteLine("\n==Find product by id(2)==");
            Console.WriteLine(Database.GetInstance().FindById(EntityType.product.ToString(), 2).TxtData());

            Console.WriteLine("\n==Find product by name(product1)==");
            Console.WriteLine(Database.GetInstance().FindByName(EntityType.product.ToString(), "product1").TxtData());

            Console.WriteLine("\nDelete all product");
            productDAO.DeleteAll(EntityType.product);
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
