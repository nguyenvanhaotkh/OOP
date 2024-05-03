using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class ProductDAO
    {
        private static ProductDAO _product;
        public static ProductDAO GetInstance()
        {
            if (_product == null)
            {
                _product = new ProductDAO();
            }
            return _product;
        }

        public void Insert(Product product)
        {
            Database.GetInstance().productTable.Add(product);
            Console.WriteLine("Insert success: " + product.TxtData());
        }

        public void Update(Product product)
        {
            Product _product = Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == product.GetId());
            if (_product != null)
            {
                Console.WriteLine("Old data: " + _product.TxtData());
                _product.SetName(product.GetName());
                _product.SetCategoryId(product.GetCategoryId());
                Console.WriteLine("Update success, new data: " + product.TxtData());
                return;
            }
            Console.WriteLine("Update fail...");
        }

        public void Delete(int id)
        {
            Database.GetInstance().productTable.RemoveAll(productObject => productObject.GetId() == id);
            Console.WriteLine("Delete success...");
        }

        public List<object> FindAll()
        {
            List<object> allData = new List<object>();
            foreach (Product _product in Database.GetInstance().productTable)
            {
                Console.WriteLine(_product.TxtData());
                allData.Add(_product);
            }
            //return (List<object>)(object)Database.GetInstance().productTable;
            return allData;
        }

        public object FindById(int id)
        {
            return Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == id);
        }

        public object FindByName(string name)
        {
            return Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetName() == name);
        }
    }
}
