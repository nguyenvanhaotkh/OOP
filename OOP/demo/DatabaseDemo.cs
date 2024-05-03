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
        public void InsertTableTest(string name, object obj)
        {
            Database.GetInstance().InsertTable(name, obj);
        }

        public void SelectTableTest(string name)
        {
            Database.GetInstance().SelectTable(name);
        }

        public void UpdateTableTest(string name, object obj)
        {
            Database.GetInstance().UpdateTable(name, obj);
        }

        public void DeleteTest(string name, int id)
        {
            Database.GetInstance().Delete(name, id);
        }

        public void DeleteAllTest(string name)
        {
            Database.GetInstance().DeleteAll(name);
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
