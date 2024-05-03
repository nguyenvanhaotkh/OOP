using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class Database
    {
        public List<Product> productTable = new List<Product>();
        public List<Category> categorieTable = new List<Category>();
        public List<Accessotion> accessotionTable = new List<Accessotion>();
        private string product = "product";
        private string category = "category";
        private string accessotion = "accessotion";

        private static Database _database;
        public static Database GetInstance()
        {
            if (_database == null)
            {
                _database = new Database();
            }
            return _database;
        }

        public void InsertTable(string name, object obj)
        {
            if (name == product) {
                ProductDAO.GetInstance().Insert((Product)obj);
                return;
            }
            if (name == category) {
                CategoryDAO.GetInstance().Insert((Category)obj);
                return;
            }
            if (name == accessotion) {
                AccessoryDAO.GetInstance().Insert((Accessotion)obj);
                return;
            }
            Console.WriteLine("Invalid value");
        }

        public List<object> SelectTable(string name)
        {
            if (name == product) {
                return ProductDAO.GetInstance().FindAll();
            }
            if (name == category) {
                return CategoryDAO.GetInstance().FindAll();
            }
            return AccessoryDAO.GetInstance().FindAll();
        }

        public void UpdateTable(string name,object obj)
        {
            if (name == product)
            {
                ProductDAO.GetInstance().Update((Product)obj);
                return;
            }
            if (name == category)
            {
                CategoryDAO.GetInstance().Update((Category)obj);
                return;
            }
            if (name == accessotion)
            {
                AccessoryDAO.GetInstance().Update((Accessotion)obj);
                return;
            }
            Console.WriteLine("Invalid value");
        }

        public void Delete(string name, int id)
        {
            if (name == product) {
                ProductDAO.GetInstance().Delete(id);
                return; 
            }
            if (name == category)
            {
                CategoryDAO.GetInstance().Delete(id);
                return;
            }
            AccessoryDAO.GetInstance().Delete(id);
        }

        public void DeleteAll(string name)
        {
            if (name == product)
            {
                productTable.Clear();
                return;
            }
            if (name == category)
            {
                categorieTable.Clear();
                return;
            }
            accessotionTable.Clear();
        }

        public void UpdateTableById(int id, object obj)
        {

        }
    }
}
