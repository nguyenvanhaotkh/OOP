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
        private ProductDAO productDAO;
        public ProductDaoDemo(ProductDAO productDAO)
        {
            this.productDAO = productDAO;
        }

        public int InsertTest(BaseRow product)
        {
            return productDAO.Insert(product,EntityType.product);
        }

        public int UpdateTest(BaseRow product)
        {
            return productDAO.Update(product);
        }

        public bool DeleteTest(int id)
        {
            return productDAO.Delete(id,EntityType.product);
        }

        public void DeleteAllTest()
        {
            productDAO.DeleteAll(EntityType.product);
        }

        public List<BaseRow> FindAllTest()
        {
            return productDAO.FindAll(EntityType.product);
        }

        public BaseRow FindById(int id)
        {
            return productDAO.FindById(id,EntityType.product);
        }

        public BaseRow FindByName(string name)
        {
            return productDAO.FindByName(name,EntityType.product);
        }
    }
}
