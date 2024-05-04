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
        private CategoryDAO categoryDAO;
        public CategoryDaoDemo(CategoryDAO categoryDAO)
        {
            this.categoryDAO = categoryDAO;
        }

        public int InsertTest(BaseRow category)
        {
            return categoryDAO.Insert(category,EntityType.category);
        }

        public int UpdateTest(BaseRow category)
        {
            return categoryDAO.Update(category);
        }

        public bool DeleteTest(int id)
        {
            return categoryDAO.Delete(id, EntityType.category);
        }

        public void DeleteAllTest()
        {
            categoryDAO.DeleteAll(EntityType.category);
        }

        public List<BaseRow> FindAllTest()
        {
            return categoryDAO.FindAll(EntityType.category);
        }

        public BaseRow FindById(int id)
        {
            return categoryDAO.FindById(id, EntityType.category);
        }

        public BaseRow FindByName(string name)
        {
            return categoryDAO.FindByName(name, EntityType.category);
        }
    }
}
