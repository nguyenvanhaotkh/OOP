using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;
using OOP.dao;

namespace OOP.demo
{
    class AccessoryDAODemo
    {
        private static AccessoryDAODemo _accessory;
        public static AccessoryDAODemo GetInstance()
        {
            if (_accessory == null)
            {
                _accessory = new AccessoryDAODemo();
            }
            return _accessory;
        }

        public void InsertTest(Accessotion accessotion)
        {
            AccessoryDAO.GetInstance().Insert(accessotion);
        }

        public void UpdateTest(Accessotion accessotion)
        {
            AccessoryDAO.GetInstance().Update(accessotion);
        }

        public void DeleteTest(int id)
        {
            AccessoryDAO.GetInstance().Delete(id);
        }

        public List<object> FindAllTest()
        {
            return AccessoryDAO.GetInstance().FindAll();
        }

        public object FindByIdTest(int id)
        {
            return AccessoryDAO.GetInstance().FindById(id);
        }

        public object FindByName(string name)
        {
            return AccessoryDAO.GetInstance().FindByName(name);
        }
    }
}
