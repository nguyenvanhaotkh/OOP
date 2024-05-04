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
        private List<BaseRow> productTable = new List<BaseRow>();
        private List<BaseRow> categorieTable = new List<BaseRow>();
        private List<BaseRow> accessotionTable = new List<BaseRow>();

        const string PRODUCT = "product";
        const string CATEGORY = "category";
        const string ACCESSOTION = "accessotion";

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
                productTable.Add(obj);
                return 1;
            }
            if (name == CATEGORY)
            {
                categorieTable.Add(obj);
                return 1;
            }

            if (name == ACCESSOTION)
            {
                accessotionTable.Add(obj);
                return 1;
            }
            return 0;
        }

        public List<BaseRow> SelectTable(string name)
        {
            if (name == PRODUCT)
            {
                return productTable;
            }
            if (name == CATEGORY)
            {
                return categorieTable;
            }
            if (name == ACCESSOTION)
            {
                return accessotionTable;
            }
            return null;
        }

        public int UpdateTable(string name,BaseRow obj)
        {
            if (name == PRODUCT)
            {
                Product _product = (Product)Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == obj.GetId());
                if (_product != null)
                {
                    Product ProductOldCategoryId = (Product)obj;
                    _product.SetName(obj.GetName());
                    _product.SetCategoryId(ProductOldCategoryId.GetCategoryId());
                }
                return 1;
            }
            if (name == CATEGORY)
            {
                Category _category = (Category)Database.GetInstance().categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == obj.GetId());
                if (_category != null)
                {
                    _category.SetName(obj.GetName());
                }
                return 1;
            }
            if (name == ACCESSOTION)
            {
                Accessotion _accessotion = (Accessotion)Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() == obj.GetId());
                if (_accessotion != null)
                {
                    _accessotion.SetName(obj.GetName());
                }
                return 1;
            }
            return 0;
        }

        public bool Delete(string name, int id)
        {
            if (name == PRODUCT) {
                productTable.RemoveAll(productObject => productObject.GetId() == id);
                return true;
            }
            if (name == CATEGORY)
            {
                categorieTable.RemoveAll(categorieObject => categorieObject.GetId() == id);
                return true;
            }
            if(name == ACCESSOTION)
            {
                accessotionTable.RemoveAll(accessotionObject => accessotionObject.GetId() == id);
                return true;
            }
            return false;
        }

        public void DeleteAll(string name)
        {
            if (name == PRODUCT)
            {
                productTable.Clear();
                return;
            }
            if (name == CATEGORY)
            {
                categorieTable.Clear();
                return;
            }
            accessotionTable.Clear();
        }

        public BaseRow FindById(string name, int id)
        {
            if (name == PRODUCT)
            {
                return productTable.FirstOrDefault(productObject => productObject.GetId() == id);
            }
            if (name == CATEGORY)
            {
                return categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == id);
            }
            if (name == ACCESSOTION)
            {
                return accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() == id);
            }
            return null;
        }

        public BaseRow FindByName(string name, string entityName)
        {
            if (name == PRODUCT)
            {
                return productTable.FirstOrDefault(productObject => productObject.GetName() == entityName);
            }
            if (name == CATEGORY)
            {
                return categorieTable.FirstOrDefault(categoryObject => categoryObject.GetName() == entityName);
            }
            if (name == ACCESSOTION)
            {
                return accessotionTable.FirstOrDefault(categoryObject => categoryObject.GetName() == entityName);
            }
            return null;
        }

        public void UpdateTableById(int id, object obj)
        {

        }
    }
}
