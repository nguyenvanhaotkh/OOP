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
        private AccessoryDAO accessoryDAO;
        public AccessoryDAODemo(AccessoryDAO accessoryDAO)
        {
            this.accessoryDAO = accessoryDAO;
        }

        public int InsertTest(BaseRow accessotion)
        {
            return accessoryDAO.Insert(accessotion,EntityType.accessotion);
        }

        public int UpdateTest(BaseRow accessotion)
        {
            return accessoryDAO.Update(accessotion);
        }

        public bool DeleteTest(int id)
        {
            return accessoryDAO.Delete(id, EntityType.accessotion);
        }

        public void DeleteAllTest()
        {
            accessoryDAO.DeleteAll(EntityType.accessotion);
        }

        public List<BaseRow> FindAllTest()
        {
            return accessoryDAO.FindAll(EntityType.accessotion);
        }

        public BaseRow FindByIdTest(int id)
        {
            return accessoryDAO.FindById(id, EntityType.accessotion);
        }

        public BaseRow FindByName(string name)
        {
            return accessoryDAO.FindByName(name, EntityType.accessotion);
        }
    }
}
