using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP.demo
{
    class CategoryDaoDemo
    {
        private static CategoryDaoDemo _category;

        public static CategoryDaoDemo GetInstance()
        {
            if (_category == null)
            {
                _category = new CategoryDaoDemo();
            }
            return _category;
        }

        public void InsertTest(Category category)
        {
            CategoryDAO.GetInstance().Insert(category);
        }

        public void UpdateTest(Category category)
        {
            CategoryDAO.GetInstance().Update(category);
        }

        public void DeleteTest(int id)
        {
            CategoryDAO.GetInstance().Delete(id);
        }

        public List<object> FindAllTest()
        {
            return CategoryDAO.GetInstance().FindAll();
        }

        public object FindById(int id)
        {
            return CategoryDAO.GetInstance().FindById(id);
        }
    }
}
