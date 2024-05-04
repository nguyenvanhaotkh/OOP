using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.dao;

namespace OOP.demo
{
    class AccessoryDAODemo
    {
        private AccessotionDemo accessotionDemo;
        private AccessoryDAO accessoryDAO;
        public AccessoryDAODemo(AccessotionDemo accessotionDemo, AccessoryDAO accessoryDAO)
        {
            this.accessotionDemo = accessotionDemo;
            this.accessoryDAO = accessoryDAO;
        }

        public void Test()
        {
            accessotionDemo.CreateCategoryTest();
            PrintData();

            Console.WriteLine("\n==Insert accessotion==");
            accessoryDAO.Insert(EntityType.accessotion, new Accessotion(5, "accessotion5"));
            PrintData();

            Console.WriteLine("\n==Update accessotion (id=5)==");
            Console.WriteLine("Old data: " + Database.GetInstance().FindById(EntityType.accessotion.ToString(), 5).TxtData());
            accessoryDAO.Update(EntityType.accessotion, new Accessotion(5, "accessotion5update"));
            Console.WriteLine("New data: " + Database.GetInstance().FindById(EntityType.accessotion.ToString(), 5).TxtData());

            Console.WriteLine("\n==Delete accessotion (id=3)==");
            accessoryDAO.Delete(EntityType.accessotion, 3);
            PrintData();

            Console.WriteLine("\n==Find accessotion by id(2)==");
            Console.WriteLine(Database.GetInstance().FindById(EntityType.accessotion.ToString(), 2).TxtData());

            Console.WriteLine("\n==Find category by name(accessotion1)==");
            Console.WriteLine(Database.GetInstance().FindByName(EntityType.accessotion.ToString(), "accessotion1").TxtData());

            Console.WriteLine("\nDelete all category");
            accessoryDAO.DeleteAll(EntityType.accessotion);
            PrintData();

        }
        public void PrintData()
        {
            foreach (BaseRow row in Database.GetInstance().SelectTable(EntityType.accessotion.ToString()))
            {
                Console.WriteLine(row.TxtData());
            }
        }
    }
}
