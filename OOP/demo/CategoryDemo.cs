using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.dao;

namespace OOP.demo
{
    class CategoryDemo
    {
        public void CreateCategoryTest()
        {
            Database.GetInstance().InsertTable(EntityType.category.ToString(), new Category(1, "category1"));
            Database.GetInstance().InsertTable(EntityType.category.ToString(), new Category(2, "category2"));
            Database.GetInstance().InsertTable(EntityType.category.ToString(), new Category(3, "category3"));
            Database.GetInstance().InsertTable(EntityType.category.ToString(), new Category(4, "category4"));
        }
        public void PrintProduct(Category category)
        {
            Console.WriteLine(category.TxtData());
        }
    }
}
