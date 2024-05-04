using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class AccessoryDAO : BaseDao<BaseRow> , IDAO
    {
        public int Update(BaseRow accessotion)
        {
            try
            {
                Accessotion _accessotion = (Accessotion)Database.GetInstance().accessotionTable.FirstOrDefault(productObject => productObject.GetId() == accessotion.GetId());
                Console.WriteLine("-Old data: " + _accessotion.TxtData());
                if (_accessotion != null)
                {
                    _accessotion.SetName(accessotion.GetName());
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
