using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class AccessoryDAO
    {
        private static AccessoryDAO _accessory;
        public static AccessoryDAO GetInstance()
        {
            if (_accessory == null)
            {
                _accessory = new AccessoryDAO();
            }
            return _accessory;
        }

        public void Insert(Accessotion accessotion)
        {
            Database.GetInstance().accessotionTable.Add(accessotion);
            Console.WriteLine("Insert success...");
        }

        public void Update(Accessotion accessotion)
        {
            Accessotion _accessotion = Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() == accessotion.GetId());
            if (_accessotion != null)
            {
                Console.WriteLine("Old data: " + _accessotion.TxtData());
                _accessotion.SetName(accessotion.GetName());
                Console.WriteLine("Update success, new data: " + accessotion.TxtData());
                return;
            }
            Console.WriteLine("Update fail...");
        }

        public void Delete(int id)
        {
            Database.GetInstance().accessotionTable.RemoveAll(accessotionObject => accessotionObject.GetId() == id);
            Console.WriteLine("Delete success...");
        }

        public List<object> FindAll()
        {
            List<object> allData = new List<object>();
            foreach (Accessotion _accessotion in Database.GetInstance().accessotionTable)
            {
                Console.WriteLine(_accessotion.TxtData());
                allData.Add(_accessotion);
            }
            //return (List<object>)(object)Database.GetInstance().accessotionTable;
            return allData;
        }

        public object FindById(int id)
        {
            return Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetId() == id);
        }

        public object FindByName(string name)
        {
            return Database.GetInstance().accessotionTable.FirstOrDefault(accessotionObject => accessotionObject.GetName() == name);
        }
    }
}
