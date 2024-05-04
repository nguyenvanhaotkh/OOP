using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP.demo
{
    class DatabaseDemo
    {
        private static DatabaseDemo _databaseDemo;
        public static DatabaseDemo GetInstance()
        {
            if (_databaseDemo == null)
            {
                _databaseDemo = new DatabaseDemo();
            }
            return _databaseDemo;
        }
        public void InsertTableTest(string name, BaseRow obj)
        {
            if(Database.GetInstance().InsertTable(name, obj) == 1)
            {
                Console.WriteLine("Insert success: " + obj.TxtData());
                return;
            }
            Console.WriteLine("Insert fail!!!");
        }

        public void SelectTableTest(string name)
        {
            List<BaseRow> baseRow = Database.GetInstance().SelectTable(name);
            foreach(BaseRow _baseRow in baseRow)
            {
                Console.WriteLine(_baseRow.TxtData());
            }
        }

        public void UpdateTableTest(string name, BaseRow obj)
        {
            if (Database.GetInstance().UpdateTable(name, obj) == 1)
            {
                Console.WriteLine("Insert success: " + obj.TxtData());
                return;
            }
            Console.WriteLine("Insert fail!!!");
        }

        public void DeleteTest(string name, int id)
        {
            if(Database.GetInstance().Delete(name, id))
            {
                Console.WriteLine("Delete success.");
                return;
            }
            Console.WriteLine("Delete fail.");
            return;
        }

        public void DeleteAllTest(string name)
        {
            Database.GetInstance().DeleteAll(name);
            Console.WriteLine("Delete all success.");
        }

        public void UpdateTableByIdTest(int id, object obj)
        {
            Database.GetInstance().UpdateTableById(id, obj);
        }

        public void PrintTable(string name)
        {
            if(name == "product")
            {
                foreach(Product product in Database.GetInstance().productTable)
                {
                    Console.WriteLine(product.TxtData());
                }
                return;
            }
            if(name == "category")
            {
                foreach (Category category in Database.GetInstance().categorieTable)
                {
                    Console.WriteLine(category.TxtData());
                }
                return;
            }
            foreach (Accessotion accessotion in Database.GetInstance().accessotionTable)
            {
                Console.WriteLine(accessotion.TxtData());
            }
        }
    }
}
