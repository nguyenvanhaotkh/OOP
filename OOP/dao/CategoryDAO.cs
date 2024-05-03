using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class CategoryDAO
    {
        private static CategoryDAO _category;

        public static CategoryDAO GetInstance()
        {
            if (_category == null)
            {
                _category = new CategoryDAO();
            }
            return _category;
        }

        public void Insert(Category category)
        {
            Database.GetInstance().categorieTable.Add(category);
            Console.WriteLine("Insert success...");
        }

        public void Update(Category category)
        {
            Category _category = Database.GetInstance().categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == category.GetId());
            if (_category != null)
            {
                Console.WriteLine("Old data: " + _category.TxtData());
                _category.SetName(category.GetName());
                Console.WriteLine("Update success, new data: " + category.TxtData());
                return;
            }
            Console.WriteLine("Update fail...");
        }

        public void Delete(int id)
        {
            Database.GetInstance().categorieTable.RemoveAll(categoryObject => categoryObject.GetId() == id);
            Console.WriteLine("Delete success...");
        }

        public List<object> FindAll()
        {
            List<object> alldata = new List<object>();
            foreach (Category _category in Database.GetInstance().categorieTable)
            {
                Console.WriteLine(_category.TxtData());
                alldata.Add(_category);
            }
            //return (List<object>)(object)Database.GetInstance().categorieTable;
            return alldata;
        }

        public object FindById(int id)
        {
            return Database.GetInstance().categorieTable.FirstOrDefault(categoryObject => categoryObject.GetId() == id);
        }
    }
}
