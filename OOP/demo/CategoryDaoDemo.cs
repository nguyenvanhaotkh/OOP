using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP.demo
{
    class CategoryDaoDemo
    {
        private CategoryDemo categoryDemo;
        private CategoryDAO categoryDAO;
        public CategoryDaoDemo(CategoryDemo categoryDemo, CategoryDAO categoryDAO)
        {
            this.categoryDemo = categoryDemo;
            this.categoryDAO = categoryDAO;
        }

        public void Test()
        {
            categoryDemo.CreateCategoryTest();
            PrintData();

            Console.WriteLine("\n==Insert category==");
            categoryDAO.Insert(EntityType.category, new Category(5, "category5"));
            PrintData();

            Console.WriteLine("\n==Update category (id=5)==");
            Console.WriteLine("Old data: " + Database.GetInstance().FindById(EntityType.category.ToString(), 5).TxtData());
            categoryDAO.Update(EntityType.category, new Category(5, "category5update"));
            Console.WriteLine("New data: " + Database.GetInstance().FindById(EntityType.category.ToString(), 5).TxtData());

            Console.WriteLine("\n==Delete category (id=3)==");
            categoryDAO.Delete(EntityType.category, 3);
            PrintData();

            Console.WriteLine("\n==Find category by id(2)==");
            Console.WriteLine(Database.GetInstance().FindById(EntityType.category.ToString(), 2).TxtData());

            Console.WriteLine("\n==Find category by name(category1)==");
            Console.WriteLine(Database.GetInstance().FindByName(EntityType.category.ToString(), "category1").TxtData());

            Console.WriteLine("\nDelete all category");
            categoryDAO.DeleteAll(EntityType.category);
            PrintData();

        }
        public void PrintData()
        {
            foreach (BaseRow row in Database.GetInstance().SelectTable(EntityType.category.ToString()))
            {
                Console.WriteLine(row.TxtData());
            }
        }
    }
}
