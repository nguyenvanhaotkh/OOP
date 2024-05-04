using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class CategoryDAO : BaseDao , IDAO
    {
        public int Update(BaseRow category)
        {
            //try
            //{
            //    Category _category = (Category)Database.GetInstance().categorieTable.FirstOrDefault(productObject => productObject.GetId() == category.GetId());
            //    Console.WriteLine("-Old data: " + _category.TxtData());
            //    if (_category != null)
            //    {
            //        _category.SetName(category.GetName());
            //    }
            //    return 1;
            //}
            //catch
            //{
                return 0;
            //}
        }
    }
}
