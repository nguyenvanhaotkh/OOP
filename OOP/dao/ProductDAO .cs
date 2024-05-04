using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.entity;

namespace OOP.dao
{
    class ProductDAO : BaseDao ,IDAO
    {
        public int Update(BaseRow product)
        {
            //try
            //{
            //    Product _product = (Product)Database.GetInstance().productTable.FirstOrDefault(productObject => productObject.GetId() == product.GetId());
            //    Console.WriteLine("-Old data: " + _product.TxtData());
            //    if (_product != null)
            //    {
            //        Product ProductOldCategoryId = (Product)product;
            //        _product.SetName(product.GetName());
            //        _product.SetCategoryId(ProductOldCategoryId.GetCategoryId());
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
