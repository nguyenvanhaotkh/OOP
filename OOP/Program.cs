using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.dao;
using OOP.entity;
using OOP.demo;

namespace OOP
{
    class Program
    {
        private ProductDaoDemo productDaoDemo = new ProductDaoDemo(new ProductDemo());
        private CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo(new CategoryDemo());
        private AccessoryDAODemo accessoryDaoDemo = new AccessoryDAODemo(new AccessotionDemo());
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestProduct();
        }
        private void TestProduct()
        {
            //productDaoDemo.Test();
            //categoryDaoDemo.Test();
            accessoryDaoDemo.Test();
        }
    }
}
