using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;

namespace OOP.demo
{
    class ProductDaoDemo
    {
        private static ProductDaoDemo _product;
        public static ProductDaoDemo GetInstance()
        {
            if (_product == null)
            {
                _product = new ProductDaoDemo();
            }
            return _product;
        }

        public void InsertTest(Product product)
        {
            ProductDAO.GetInstance().Insert(product);
        }

        public void UpdateTest(Product product)
        {
            ProductDAO.GetInstance().Update(product);
        }

        public void DeleteTest(int id)
        {
            ProductDAO.GetInstance().Delete(id);
        }

        public List<object> FindAllTest()
        {
            return ProductDAO.GetInstance().FindAll();
        }

        public object FindById(int id)
        {
            return ProductDAO.GetInstance().FindById(id);
        }

        public object FindByName(string name)
        {
            return ProductDAO.GetInstance().FindByName(name);
        }
    }
}
