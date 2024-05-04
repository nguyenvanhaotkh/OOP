using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    abstract class BaseDao
    {
        public int Insert(EntityType type, BaseRow obj)
        {
            try
            {
                Database.GetInstance().InsertTable(type.ToString(), obj);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public int Update(EntityType type,BaseRow obj)
        {
            try
            {
                Database.GetInstance().UpdateTable(type.ToString(), obj);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public bool Delete(EntityType type, int id)
        {
            try
            {
                Database.GetInstance().Delete(type.ToString(), id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteAll(EntityType type)
        {
            Database.GetInstance().DeleteAll(type.ToString());
        }

        public List<BaseRow> FindAll(EntityType type)
        {
            return Database.GetInstance().SelectTable(type.ToString());
        }

        public BaseRow FindById(int id, EntityType type)
        {
            return Database.GetInstance().FindById(type.ToString(),id);
        }

        public BaseRow FindByName(string name, EntityType type)
        {
            return Database.GetInstance().FindByName(type.ToString(),name);
        }
    }

    enum EntityType
    {
        product,
        category,
        accessotion
    }
}
