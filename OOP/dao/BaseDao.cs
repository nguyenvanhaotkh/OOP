using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    abstract class BaseDao<T> where T : BaseRow
    {
        protected List<T> GetTable(EntityType type)
        {
            switch (type)
            {
                case EntityType.product:
                    return Database.GetInstance().productTable as List<T>;
                case EntityType.category:
                    return Database.GetInstance().categorieTable as List<T>;
                case EntityType.accessotion:
                    return Database.GetInstance().accessotionTable as List<T>;
                default:
                    throw new ArgumentException("Invalid entity type");
            }
        }

        public int Insert(T obj, EntityType type)
        {
            try
            {
                GetTable(type).Add(obj);
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public bool Delete(int id, EntityType type)
        {
            try
            {
                GetTable(type).RemoveAll(productObject => productObject.GetId() == id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void DeleteAll(EntityType type)
        {
            GetTable(type).Clear();
        }

        public List<T> FindAll(EntityType type)
        {
            return GetTable(type);
        }

        public BaseRow FindById(int id, EntityType type)
        {
            return GetTable(type).FirstOrDefault(Object => Object.GetId() == id);
        }

        public BaseRow FindByName(string name, EntityType type)
        {
            return GetTable(type).FirstOrDefault(Object => Object.GetName() == name);
        }
    }

    enum EntityType
    {
        product,
        category,
        accessotion
    }
}
