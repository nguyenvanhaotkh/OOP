using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.demo;

namespace OOP.dao
{
    class Database
    {
        public List<BaseRow> productTable = new List<BaseRow>();
        public List<BaseRow> categorieTable = new List<BaseRow>();
        public List<BaseRow> accessotionTable = new List<BaseRow>();

        const string PRODUCT = "product";
        const string CATEGORY = "category";
        const string ACCESSOTION = "accessotion";

        private ProductDaoDemo productDaoDemo = new ProductDaoDemo(new ProductDAO());
        private CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo(new CategoryDAO());
        private AccessoryDAODemo accessoryDaoDemo = new AccessoryDAODemo(new AccessoryDAO());

        private static Database _database;
        public static Database GetInstance()
        {
            if (_database == null)
            {
                _database = new Database();
            }
            return _database;
        }

        public int InsertTable(string name, BaseRow obj)
        {
            if (name == PRODUCT) {
                return productDaoDemo.InsertTest(obj);
            }
            if (name == CATEGORY)
            {
                return categoryDaoDemo.InsertTest(obj);
            }

            if (name == ACCESSOTION)
            {
                return accessoryDaoDemo.InsertTest(obj);
            }
            return 0;
        }

        public List<BaseRow> SelectTable(string name)
        {
            if (name == PRODUCT)
            {
                return productDaoDemo.FindAllTest();
            }
            if (name == CATEGORY)
            {
                return categoryDaoDemo.FindAllTest();
            }
            if (name == ACCESSOTION)
            {
                return accessoryDaoDemo.FindAllTest();
            }
            return null;
        }

        public int UpdateTable(string name,BaseRow obj)
        {
            if (name == PRODUCT)
            {
                return productDaoDemo.UpdateTest(obj);
            }
            if (name == CATEGORY)
            {
                return categoryDaoDemo.UpdateTest(obj);
            }
            if (name == ACCESSOTION)
            {
                return accessoryDaoDemo.UpdateTest(obj);
            }
            return 0;
        }

        public bool Delete(string name, int id)
        {
            if (name == PRODUCT) {
                return productDaoDemo.DeleteTest(id); 
            }
            if (name == CATEGORY)
            {
                return categoryDaoDemo.DeleteTest(id);
            }
            if(name == ACCESSOTION)
            {
                return accessoryDaoDemo.DeleteTest(id);
            }
            return false;
        }

        public void DeleteAll(string name)
        {
            if (name == PRODUCT)
            {
                productDaoDemo.DeleteAllTest();
                return;
            }
            if (name == CATEGORY)
            {
                categoryDaoDemo.DeleteAllTest();
                return;
            }
            accessoryDaoDemo.DeleteAllTest();
        }

        public void UpdateTableById(int id, object obj)
        {

        }
    }
}
