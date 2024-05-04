using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.dao;

namespace OOP.demo
{
    class AccessotionDemo
    {
        public void CreateCategoryTest()
        {
            Database.GetInstance().InsertTable(EntityType.accessotion.ToString(), new Accessotion(1, "accessotion1"));
            Database.GetInstance().InsertTable(EntityType.accessotion.ToString(), new Accessotion(2, "accessotion2"));
            Database.GetInstance().InsertTable(EntityType.accessotion.ToString(), new Accessotion(3, "accessotion3"));
            Database.GetInstance().InsertTable(EntityType.accessotion.ToString(), new Accessotion(4, "accessotion4"));
        }
        public void PrintProduct(Accessotion accessotion)
        {
            Console.WriteLine(accessotion.TxtData());
        }
    }
}
